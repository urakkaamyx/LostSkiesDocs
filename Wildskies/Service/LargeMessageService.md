# WildSkies.Service.LargeMessageService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| MessageReceived | System.Action`2<WildSkies.Service.LargeMessageType,System.Byte[]> | Public |
| _largeMessageRelay | LargeMessageRelay | Private |
| MaxMessageSize | System.Int32 | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetLargeMessageRelay(LargeMessageRelay largeMessageRelay)**: System.Void (Public)
- **DestroyLargeMessageRelay()**: System.Void (Public)
- **SendMessage(WildSkies.Service.LargeMessageType messageType, System.Byte[] messageContents)**: System.Void (Public)
- **ReceiveMessage(WildSkies.Service.LargeMessageType messageType, System.Byte[] messageContents)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

