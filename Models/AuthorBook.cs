namespace SelfAspNet.Models;

// AuthorBookテーブルは多:多の関係を表すコレクションナビゲーションを指定した際に自動的に作られるが、明示的にアクセスしたい場合は手動で作成することもできる
// 主キーは持たない

public class AuthorBook
{
  public Author Author { get; set; } = null!;
  public Book Book { get; set; } = null!;
}