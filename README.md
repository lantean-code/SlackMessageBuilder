SlackMessageBuilder.NewtonsoftJson [![NuGet version](https://badge.fury.io/nu/SlackMessageBuilder.NewtonsoftJson.svg)](https://badge.fury.io/nu/SlackMessageBuidler.NewtonsoftJson)

SlackMessageBuilder.SystemTextJson [![NuGet version](https://badge.fury.io/nu/SlackMessageBuilder.SystemTextJson.svg)](https://badge.fury.io/nu/SlackMessageBuilder.SystemTextJson)

# SlackMessageBuilder

A fluent style builder for creating Slack Messages. Supports both legacy Attachments and <https://api.slack.com/block-kit|Block Kit>.

Separate packages for System.Text.Json and Newtonsoft.Json

## How to use

Example

```csharp
var builder = SlackMessageBuilder.CreateApiMessage("my-channel", "*Some fallback text*", isMarkdown: true)
    .WithBlocks(blockBuilder => blockBuilder
    .AddHeaderBlock("Header Text")
    .AddContextBlock(contextBuilder =>
    {
        contextBuilder.AddImage("https://url-to-image", "alt-text");
        contextBuilder.AddMarkdown("*Do you like my image?*");
    })
    .AddImageBlock("https://url-to-big-image", title: "Big Image Title")
    .AddDividerBlock()
    .AddMarkdownSectionBlock("A markdown section block"));

var message = builder.Build();

var json = message.ToJson();
```

## REF

- [Block Kit Builder](https://app.slack.com/block-kit-builder) You can use this website to preview the json output.
