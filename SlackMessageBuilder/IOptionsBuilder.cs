﻿namespace SlackMessageBuilder
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOptionsBuilder<T>
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        IOptionsBuilder<T> AddOption(Option option);
    }
}