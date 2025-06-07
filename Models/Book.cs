using System.ComponentModel.DataAnnotations;

namespace SelfAspNet.Models;

public class Book
{
  public int Id { get; set; }
  [Display(Name = "ISBN")]
  public string Isbn { get; set; } = String.Empty;
  [Display(Name = "タイトル")]
  public string Title { get; set; } = String.Empty;
  [Display(Name = "価格")]
  public int Price { get; set; }
  [Display(Name = "出版社")]
  public string Publisher { get; set; } = String.Empty;
  [Display(Name = "刊行日")]
  public DateTime Published { get; set; }
  [Display(Name = "配布サンプル")]
  public bool Sample { get; set; }

  // virtual = オーバーライド可能。遅延読み込みやプロキシ生成が有効になる
  // プロキシ＝自動生成。virtual付きのプロパティにアクセスした時にデータが読み込まれていなければ、自動でデータ取得を行なってくれる
  public virtual ICollection<Review> Reviews { get; } = new List<Review>();

  public virtual ICollection<Author> Authors { get; } = new List<Author>();
}

