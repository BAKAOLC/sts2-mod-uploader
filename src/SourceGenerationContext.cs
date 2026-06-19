using System.Text.Json.Serialization;

namespace ModUploader;

[JsonSourceGenerationOptions(WriteIndented = true, IncludeFields = true)]
[JsonSerializable(typeof(ModConfig))]
[JsonSerializable(typeof(LocalizedModText))]
internal partial class SourceGenerationContext : JsonSerializerContext { }
