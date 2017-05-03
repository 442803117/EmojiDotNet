using System.Collections.Generic;

namespace cn.lds.chatcore.pcw.Emoji.Entity {

/// <summary>
/// 表情包对象
/// </summary>
public class EmojiPackage {

    /// <summary>
    /// 封面路径
    /// </summary>
    public string AlbumCover {
        get;
        set;
    }

    public string AlbumSelectedCover {
        get;
        set;
    }

    /// <summary>
    /// 表情包名称
    /// </summary>
    public string Title {
        get;
        set;
    }

    /// <summary>
    /// 表情列表
    /// </summary>
    public List<EmojiItem> Items {
        get;
        set;
    }


    /// <summary>
    /// 表情包作者
    /// </summary>
    public string Author {
        get;
        set;
    }
}

}
