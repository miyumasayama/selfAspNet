using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SelfAspNet.Models;

public class Author
{
  public int Id { get; set; }

  [Display(Name = "ペンネーム")]
  public string PenName { get; set; } = String.Empty;

  [Display(Name = "ユーザー")]

  // 依存エンティティに外部キーを設定する。1:1の関係でも主従関係を明示するために必要。
  public int UserId { get; set; }

  public User User { get; set; } = null!;
  // [JsonIgnore]

  // コレクションナビゲーション。多:多の関係を表す。これによりAuthoBookのような中間テーブルが自動的に生成される。
  public ICollection<Book> Books { get; } = new List<Book>();

  // public virtual User User { get; set; } = null!;
  // public virtual ICollection<Book> Books { get; } = new List<Book>();
}