using System;
using System.Drawing;
using System.IO;
using System.Security.Permissions;
using System.Windows.Media.Imaging;

namespace cn.lds.chatcore.pcw.Emoji.Entity {

/// <summary>
/// 表情包内的单个表情对象(默认表情)
/// </summary>
public class DefaultsEmojiItem: EmojiItem {

    /// <summary>
    /// 图标
    /// </summary>
    public BitmapImage Icon {
        set;
        get;
    }

    /// <summary>
    /// 编码是否是双字节
    /// </summary>
    public bool IsShort {
        set;
        get;
    }

    public DefaultsEmojiItem(string path, string title, string code, bool isShort) {
        Type = EmojiType.Defaults;
        ImgPath = "pack://application:,,,/Emoji;Component/images/defaults/emoji_" + path;
        Title = title;
        Code = code;
        Icon = new BitmapImage(new Uri(ImgPath));
        IsShort = isShort;
    }

    public DefaultsEmojiItem(string path, string title, string code) {
        Type = EmojiType.Defaults;
        ImgPath = "pack://application:,,,/Emoji;Component/images/defaults/emoji_" + path;
        Title = title;
        Code = code;
        Icon = new BitmapImage(new Uri(ImgPath));
        IsShort = false;
    }

    public DefaultsEmojiItem() {
    }
}
}
