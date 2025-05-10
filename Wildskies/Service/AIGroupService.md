# WildSkies.Service.AIGroupService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _groups | WildSkies.Service.AIGroup[] | Private |
| _tempEntitiesList | System.Collections.Generic.List`1<WildSkies.Entities.IAIGroupMember> | Private |
| OnGroupChanged | System.Action`1<System.Int32> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **CreateGroup(System.Collections.Generic.List`1<WildSkies.Entities.AIEntity> members)**: System.Int32 (Public)
- **CreateGroup(System.Collections.Generic.List`1<WildSkies.Entities.IAIGroupMember> members)**: System.Int32 (Public)
- **JoinGroup(WildSkies.Entities.IAIGroupMember groupMemberToJoin, WildSkies.Entities.IAIGroupMember member)**: System.Void (Public)
- **JoinGroup(System.Int32 groupId, WildSkies.Entities.IAIGroupMember member)**: System.Void (Public)
- **FindNewGroup(WildSkies.Entities.IAIGroupMember member)**: System.Void (Public)
- **LeaveGroup(WildSkies.Entities.IAIGroupMember member)**: System.Void (Public)
- **DisbandGroup(WildSkies.Entities.IAIGroupMember member)**: System.Void (Public)
- **AuthorityChangeAddToGroup(WildSkies.Entities.IAIGroupMember member)**: System.Void (Public)
- **GetMembersInGroup(WildSkies.Entities.IAIGroupMember member)**: System.Collections.Generic.List`1<WildSkies.Entities.IAIGroupMember> (Public)
- **GetGroupLeader(WildSkies.Entities.IAIGroupMember member)**: WildSkies.Entities.IAIGroupMember (Public)
- **GetGroupSize(WildSkies.Entities.IAIGroupMember member)**: System.Int32 (Public)
- **GetGroupSize(System.Int32 groupId)**: System.Int32 (Public)
- **IsLeader(WildSkies.Entities.IAIGroupMember member)**: System.Boolean (Public)
- **IsInGroup(WildSkies.Entities.IAIGroupMember member)**: System.Boolean (Public)
- **GetGroupIndex(WildSkies.Entities.IAIGroupMember member)**: System.Int32 (Public)
- **FindLeader(System.Collections.Generic.List`1<WildSkies.Entities.IAIGroupMember> members, WildSkies.Entities.IAIGroupMember& leader)**: System.Void (Private)
- **UpdateLeader(System.Collections.Generic.List`1<WildSkies.Entities.IAIGroupMember> members)**: System.Void (Private)
- **AddGroup(WildSkies.Service.AIGroup group)**: System.Int32 (Private)
- **RemoveGroup(System.Int32 id)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

