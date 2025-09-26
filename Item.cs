using System.Text.Json.Serialization;

namespace StorePermission;

public class PermissionItem
{
  [JsonPropertyName("price")]
  public int Price { get; set; }

  [JsonPropertyName("permissions")]
  public List<string> Permissions { get; set; } = new List<string>();

  // New optional flag: whether this item can be sold (default true)
  [JsonPropertyName("can_sell")]
  public bool CanSell { get; set; } = true;
}
