// Copyright (c) coherence ApS.
// See the license file in the package root for more information.

namespace Coherence.Editor.Toolkit
{
    using Coherence.Toolkit;
    using System;
    using UnityEditor;
    using UnityEditor.PackageManager.Requests;
    using UnityEngine;

    internal partial class CoherenceSyncEditor
    {
        private static partial class GUIStyles
        {
            public static readonly GUIStyle authorityButton = new GUIStyle(EditorStyles.miniButton)
            {
                stretchWidth = false,
                fixedHeight = 18,
                fixedWidth = 70,
            };
        }

        private static partial class GUIContents
        {
            public static readonly GUIContent title = EditorGUIUtility.TrTextContent("Play Mode Information");
            public static readonly GUIContent help = EditorGUIUtility.TrIconContent("_Help", "Open Authority Documentation");

            public static readonly GUIContent syncDisabled = EditorGUIUtility.TrTextContentWithIcon("CoherenceSync is automatically disabled when there's no CoherenceBridge found or it cannot establish a connection with the coherence network.\n\nIf the entity needs to be networked, ensure that there is an active CoherenceBridge in the scene.\n\nCreate a CoherenceBridge via menu item GameObject/coherence/Coherence Bridge", "Info");
            public static readonly GUIContent noBridge = EditorGUIUtility.TrTextContentWithIcon("Entity not networked: CoherenceBridge not found.\nCreate a CoherenceBridge via menu item GameObject/coherence/Coherence Bridge ", "Warning");
            public static readonly GUIContent notConnected = EditorGUIUtility.TrTextContentWithIcon("Connect to display this entity's state.", "Info");
            public static readonly GUIContent usingSimulators = EditorGUIUtility.TrTextContentWithIcon("When using CoherenceInput you can request State and Input authority separately.", "Info");

            public static readonly GUIContent entity = EditorGUIUtility.TrTextContent("Entity ID", "The Entity ID associated with this CoherenceSync");
            public static readonly GUIContent uuid = EditorGUIUtility.TrTextContent("UUID", "The persistence Unique ID can be setup manually. It is autogenerated at runtime otherwise.");
            public static readonly GUIContent lod = EditorGUIUtility.TrTextContent("LOD", "The current Level of Detail of this entity");
            public static readonly GUIContent lodDisabled = EditorGUIUtility.TrTextContent("LOD", "This entity is not using Levels of Detail");
            public static readonly GUIContent lodNone = EditorGUIUtility.TrTextContent("(none)");

            public static readonly GUIContent abandonAuthority = EditorGUIUtility.TrTextContent("Abandon", "An abandoned entity is transferred to the RS, becoming orphaned. Clients are able to request authority over this entity.\n\nThis entity is set to auto-adopt, meaning clients will try to get authority over this entity once it has become orphaned");
            public static readonly GUIContent adopt = EditorGUIUtility.TrTextContent("Adopt", "Adopting Entity will alter your Authority request");
            public static readonly GUIContent interpolationWarning = EditorGUIUtility.TrTextContentWithIcon("Setting the value to 'Nothing' will prevent samples from being applied. This is not equivalent to setting interpolation to 'None'.", "Warning");

            public static readonly GUIContent authority = EditorGUIUtility.TrTextContent("Authority", "Determines who is responsible for simulating the entity.");
            public static readonly GUIContent requestAuthority = EditorGUIUtility.TrTextContent("Request Authority", "Send a request to the Replication Server to change the authority of the entity.");
            public static readonly GUIContent hasStateAuthority = Icons.GetContentWithText("Coherence.Hierarchy.Simulated", "State", "Owning the state of this entity.");
            public static readonly GUIContent hasNoStateAuthority = Icons.GetContentWithText("Coherence.Hierarchy.Networked", "State", "Not owning the state of this entity.");

            public static readonly GUIContent hasInputAuthority = Icons.GetContentWithText("Coherence.Input", "Input", "Owning the input/control of this entity.");
            public static readonly GUIContent hasNoInputAuthority = Icons.GetContentWithText("Coherence.Input.Remote", "Input", "Not owning the input/control of this entity.");
            public static readonly GUIContent persistence = EditorGUIUtility.TrTextContent("Persistence");
            public static readonly GUIContent notPersistent = EditorGUIUtility.TrTextContent("Not Persistent");
            public static readonly GUIContent changePersistence = EditorGUIUtility.TrTextContent("Change Persistence");
            public static readonly GUIContent isOrphaned = EditorGUIUtility.TrTextContent("Is Orphaned");
            public static readonly GUIContent hasOwner = EditorGUIUtility.TrTextContent("Has Owner");
        }

        internal void DrawPlaymode()
        {
            DrawTitleBar();

            if (!sync.isActiveAndEnabled)
            {
                EditorGUILayout.HelpBox(GUIContents.syncDisabled);
                return;
            }

            if (sync.CoherenceBridge == null)
            {
                EditorGUILayout.HelpBox(GUIContents.noBridge);
                return;
            }

            if (!sync.CoherenceBridge.IsConnected)
            {
                EditorGUILayout.HelpBox(GUIContents.notConnected);
                return;
            }

            EditorGUILayout.BeginVertical(GUI.skin.box);

            DrawAuthority();
            DrawPersistence();

            EditorGUILayout.Space();

            // TODO cache strings to reduce allocs
            EditorGUILayout.LabelField(GUIContents.entity, EditorGUIUtility.TrTempContent(sync.EntityState.EntityID.ToString()));
            EditorGUILayout.LabelField(GUIContents.uuid, EditorGUIUtility.TrTempContent(sync.EntityState.CoherenceUUID.ToString()));

            if (sync.UsesLODsAtRuntime)
            {
                EditorGUILayout.LabelField(GUIContents.lod, EditorGUIUtility.TrTempContent(sync.Archetype.LastObservedLodLevel.ToString()));
            }
            else
            {
                EditorGUI.BeginDisabledGroup(true);
                EditorGUILayout.LabelField(GUIContents.lodDisabled, GUIContents.lodNone);
                EditorGUI.EndDisabledGroup();
            }

            EditorGUILayout.EndVertical();
        }

        private void DrawTitleBar()
        {
            GUILayout.BeginHorizontal();
            EditorGUILayout.LabelField(GUIContents.title);
            if (GUILayout.Button(GUIContents.help, EditorStyles.label, GUILayout.ExpandWidth(false)))
            {
                Application.OpenURL(DocumentationLinks.GetDocsUrl(DocumentationKeys.Authority));
            }
            GUILayout.EndHorizontal();
        }

        private void RequestAuthority(AuthorityType authorityType)
        {
            if (!sync.RequestAuthority(authorityType))
            {
                var window = EditorWindow.focusedWindow;
                if (window)
                {
                    window.ShowNotification(new GUIContent($"Failed to request authority of type '{authorityType}'"));
                }
            }
        }

        private void DrawAuthority()
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField(GUIContents.authority, sync.HasStateAuthority ? GUIContents.hasStateAuthority : GUIContents.hasNoStateAuthority);
            GUILayout.Label(sync.HasInputAuthority ? GUIContents.hasInputAuthority : GUIContents.hasNoInputAuthority);
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel(GUIContents.requestAuthority);
            EditorGUILayout.BeginVertical();
            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginDisabledGroup(sync.HasStateAuthority);
            if (GUILayout.Button("State", EditorStyles.miniButton))
            {
                RequestAuthority(AuthorityType.State);
            }
            EditorGUI.EndDisabledGroup();
            EditorGUI.BeginDisabledGroup(sync.HasInputAuthority);
            if (GUILayout.Button("Input", EditorStyles.miniButton))
            {
                RequestAuthority(AuthorityType.Input);
            }
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndHorizontal();
            EditorGUI.BeginDisabledGroup(sync.HasStateAuthority && sync.HasInputAuthority);
            if (GUILayout.Button("Full", EditorStyles.miniButton))
            {
                RequestAuthority(AuthorityType.Full);
            }
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndVertical();
            EditorGUILayout.EndHorizontal();
        }

        private void DrawPersistence()
        {
            GUIContent persistentContent;
            if (sync.IsPersistent)
            {
                persistentContent = sync.IsOrphaned ? GUIContents.isOrphaned : GUIContents.hasOwner;
            }
            else
            {
                persistentContent = GUIContents.notPersistent;
            }

            EditorGUILayout.LabelField(GUIContents.persistence, persistentContent);

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel(GUIContents.changePersistence);

            EditorGUI.BeginDisabledGroup(!sync.IsOrphaned);
            if (GUILayout.Button(GUIContents.adopt, EditorStyles.miniButton))
            {
                sync.Adopt();
            }
            EditorGUI.EndDisabledGroup();

            var canAbandon = sync.HasStateAuthority &&
                             !sync.IsOrphaned &&
                             sync.IsPersistent &&
                             sync.authorityTransferType != CoherenceSync.AuthorityTransferType.NotTransferable;

            EditorGUI.BeginDisabledGroup(!canAbandon);
            if (GUILayout.Button(GUIContents.abandonAuthority, EditorStyles.miniButton))
            {
                sync.AbandonAuthority();
            }
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.EndHorizontal();
        }
    }
}
