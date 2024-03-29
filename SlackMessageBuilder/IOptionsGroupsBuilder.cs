﻿using Slack.MessageBuilder.Objects;

namespace Slack.MessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOptionsGroupsBuilder<in T>
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="optionsGroup"></param>
        /// <returns></returns>
        IOptionsGroupsBuilder<T> AddOptionsGroup(OptionsGroup optionsGroup);
    }
}