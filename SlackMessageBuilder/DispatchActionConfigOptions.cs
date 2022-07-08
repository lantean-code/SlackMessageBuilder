using System;

namespace SlackMessageBuilder
{
    [Flags]
    public enum DispatchActionConfigOptions
    {
        OnEnterPressed = 1,
        OnCharacterEntered = 2
    }
}