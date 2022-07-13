using System;

namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    [Flags]
    public enum DispatchActionConfigOptions
    {
        /// <summary>
        ///
        /// </summary>
        OnEnterPressed = 1,

        /// <summary>
        ///
        /// </summary>
        OnCharacterEntered = 2
    }
}