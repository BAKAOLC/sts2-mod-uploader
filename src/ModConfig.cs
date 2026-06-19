namespace ModUploader;

public class ModConfig
{
  public string? title;
  public string? description;
  public Dictionary<string, LocalizedModText>? localized;
  public string? visibility;
  public string? changeNote;
  public List<string>? tags;
  public List<ulong>? dependencies;
  public string? minBranch;
  public string? maxBranch;
}

public class LocalizedModText
{
  public string? title;
  public string? description;
}
