﻿using System;

namespace Slack.MessageBuilder.Objects
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