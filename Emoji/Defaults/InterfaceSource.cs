using System.Collections.Generic;
using Doit.Chat.Emoji.Entity;

namespace Doit.Chat.Emoji.Emoji.Defaults {
public interface InterfaceSource {
    /// <summary>
    /// 生成表情包对象
    /// </summary>
    /// <returns></returns>
    EmojiPackage ToEmojiPackage();

    /// <summary>
    /// 表情编码和表情对象的字典
    /// </summary>
    /// <returns></returns>
    Dictionary<string, EmojiItem> EmojiToIcoDictionary();

    /// <summary>
    /// 图标路径和表情对象的字典
    /// </summary>
    /// <returns></returns>
    Dictionary<string, EmojiItem> IcoToEmojiDictionary();

}
}
