using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfAspNet.Models;

namespace SelfAspNet.Controllers;

public class EntityController : Controller
{
  private readonly MyContext _db;

  public EntityController(MyContext db)
  {
    _db = db;
  }

  public async Task<IActionResult> Assoc(int id = 1)
  {
    // 遅延読み込みにより関連データを取得できる
    var b = await _db.Books.FindAsync(id);
    return View(b);

    // 初期問い合わせでまとめてデータ取得
    // var b = await _db.Books
    //   .Include(b => b.Reviews) // Booksと、関連するデータを取得する(Include)
    //   .Include(b => b.Authors)
    //   .ThenInclude(a => a.User) // Authorsを取得し、それに関連するUserを取得する(ThenInclude)
    //   .SingleAsync(b => b.Id == id);
    // return View(b);

    // 任意のタイミングでデータ取得
    // var b = await _db.Books.SingleAsync(b => b.Id == id)
    // await _db.Entry(b)
    //   .Collection(b => b.Reviews)
    //   .LoadAsync();  
    // await _db.Entry(b)
    //   .Collection(b => b.Authors)
    //   .LoadAsync(); 
    // return View(b);
  }
}


// 関連データの読み込みは、まず一括読み込み（Include)を検討する
// dbへのアクセスを最小限に抑えられるから
// 初期データの読み込みが気になるときは遅延読み込みを使用できるが、foreachなどでデータを繰り返し取得す時にアクセスが増える可能性がある