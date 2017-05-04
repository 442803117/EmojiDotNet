namespace Doit.Chat.Emoji.Entity {

public enum EmojiType {
    Defaults,
    Custom
}
/// <summary>
/// 表情包内的单个表情对象
/// </summary>
public class EmojiItem {

    public EmojiType Type {
        get;
        set;
    }

    /// <summary>
    /// 表情图片文件路径
    /// </summary>
    public string ImgPath {
        get;
        set;
    }



    /// <summary>
    /// 表情标题
    /// </summary>
    public string Title {
        get;
        set;
    }

    /// <summary>
    /// 表情对应的符号
    /// </summary>
    public string Code {
        get;
        set;
    }

    public EmojiItem(EmojiType type, string path, string title, string code) {
        Type = type;
        ImgPath = path;
        Title = title;
        Code = code;
    }
    public EmojiItem() {
    }
}
}
