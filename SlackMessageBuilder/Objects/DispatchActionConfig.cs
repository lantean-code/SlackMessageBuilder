using System.Collections.Generic;

namespace Slack.MessageBuilder.Objects
{
    /// <summary>
    /// Determines when a plain-text input element will return a block_actions interaction payload.
    ///
    /// <a href="https://api.slack.com/reference/block-kit/composition-objects#dispatch_action_config">https://api.slack.com/reference/block-kit/composition-objects#dispatch_action_config</a>
    /// </summary>
    public class DispatchActionConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispatchActionConfig"/> class.
        /// </summary>
        /// <param name="triggerActionsOn">An array of interaction types that you would like to receive a block_actions payload for.</param>
        public DispatchActionConfig(IEnumerable<string> triggerActionsOn)
        {
            TriggerActionsOn = triggerActionsOn;
        }

        /// <summary>
        /// An array of interaction types that you would like to receive a block_actions payload for. Should be one or both of:
        ///
        /// on_enter_pressed — payload is dispatched when user presses the enter key while the input is in focus.Hint text will appear underneath the input explaining to the user to press enter to submit.
        /// on_character_entered — payload is dispatched when a character is entered (or removed) in the input.
        /// </summary>
#if NEWTONSOFTJSON || DEBUG
        [Newtonsoft.Json.JsonProperty("trigger_actions_on")]
#elif SYSTEMTEXTJSON|| DEBUG
        [System.Text.Json.Serialization.JsonPropertyName("trigger_actions_on")]
#endif
        public IEnumerable<string>? TriggerActionsOn { get; set; }
    }
}