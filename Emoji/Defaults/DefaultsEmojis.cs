using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using cn.lds.chatcore.pcw.Emoji.Entity;

namespace cn.lds.chatcore.pcw.Emoji.Emoji.Defaults {
public class DefaultsEmojis {

    private static readonly DefaultsEmojis instance = new DefaultsEmojis();
    static DefaultsEmojis() {

    }

    private DefaultsEmojis() {
        // 初始化
        this.SourceList = new List<InterfaceSource>() {
            new People(),
                new Nature(),
                new Objects(),
                new Places(),
                new Symbols()
        };

        this.EmojiToIcoDictionary = new Dictionary<string, EmojiItem>();
        this.IcoToEmojiDictionary = new Dictionary<string, EmojiItem>();
        foreach (var source in this.SourceList) {
            this.EmojiToIcoDictionary =
                this.EmojiToIcoDictionary.Concat(source.EmojiToIcoDictionary()).ToDictionary(k => k.Key, v => v.Value);
            this.IcoToEmojiDictionary = this.IcoToEmojiDictionary.Concat(source.IcoToEmojiDictionary()).ToDictionary(k => k.Key, v => v.Value);
        }
    }

    public static DefaultsEmojis Instance {
        get {
            return instance;
        }
    }


    public List<InterfaceSource> SourceList {
        set;
        get;
    }

    /// <summary>
    /// Code & item
    /// </summary>
    public Dictionary<string, EmojiItem> EmojiToIcoDictionary {
        get;
        set;
    }

    /// <summary>
    /// imgPath & item
    /// </summary>
    public Dictionary<string, EmojiItem> IcoToEmojiDictionary {
        get;
        set;
    }

}
}
