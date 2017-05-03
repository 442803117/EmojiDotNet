using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using cn.lds.chatcore.pcw.Emoji.Entity;

namespace cn.lds.chatcore.pcw.Emoji.Emoji.Defaults {
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
