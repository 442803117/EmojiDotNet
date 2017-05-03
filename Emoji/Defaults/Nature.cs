using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cn.lds.chatcore.pcw.Emoji.Entity;

namespace cn.lds.chatcore.pcw.Emoji.Emoji.Defaults {
public class Nature: InterfaceSource {

    private readonly List<EmojiItem> items = new List<EmojiItem>() {
        new DefaultsEmojiItem("1f436.png","","0x1f436"),
            new DefaultsEmojiItem("1f43a.png","","0x1f43a"),
            new DefaultsEmojiItem("1f431.png","","0x1f431"),
            new DefaultsEmojiItem("1f42d.png","","0x1f42d"),
            new DefaultsEmojiItem("1f439.png","","0x1f439"),
            new DefaultsEmojiItem("1f430.png","","0x1f430"),
            new DefaultsEmojiItem("1f438.png","","0x1f438"),
            new DefaultsEmojiItem("1f42f.png","","0x1f42f"),
            new DefaultsEmojiItem("1f428.png","","0x1f428"),
            new DefaultsEmojiItem("1f43b.png","","0x1f43b"),
            new DefaultsEmojiItem("1f437.png","","0x1f437"),
            new DefaultsEmojiItem("1f43d.png","","0x1f43d"),
            new DefaultsEmojiItem("1f42e.png","","0x1f42e"),
            new DefaultsEmojiItem("1f417.png","","0x1f417"),
            new DefaultsEmojiItem("1f435.png","","0x1f435"),
            new DefaultsEmojiItem("1f412.png","","0x1f412"),
            new DefaultsEmojiItem("1f434.png","","0x1f434"),
            new DefaultsEmojiItem("1f411.png","","0x1f411"),
            new DefaultsEmojiItem("1f418.png","","0x1f418"),
            new DefaultsEmojiItem("1f43c.png","","0x1f43c"),
            new DefaultsEmojiItem("1f427.png","","0x1f427"),
            new DefaultsEmojiItem("1f426.png","","0x1f426"),
            new DefaultsEmojiItem("1f424.png","","0x1f424"),
            new DefaultsEmojiItem("1f425.png","","0x1f425"),
            new DefaultsEmojiItem("1f423.png","","0x1f423"),
            new DefaultsEmojiItem("1f414.png","","0x1f414"),
            new DefaultsEmojiItem("1f40d.png","","0x1f40d"),
            new DefaultsEmojiItem("1f422.png","","0x1f422"),
            new DefaultsEmojiItem("1f41b.png","","0x1f41b"),
            new DefaultsEmojiItem("1f41d.png","","0x1f41d"),
            new DefaultsEmojiItem("1f41c.png","","0x1f41c"),
            new DefaultsEmojiItem("1f41e.png","","0x1f41e"),
            new DefaultsEmojiItem("1f40c.png","","0x1f40c"),
            new DefaultsEmojiItem("1f419.png","","0x1f419"),
            new DefaultsEmojiItem("1f41a.png","","0x1f41a"),
            new DefaultsEmojiItem("1f420.png","","0x1f420"),
            new DefaultsEmojiItem("1f41f.png","","0x1f41f"),
            new DefaultsEmojiItem("1f42c.png","","0x1f42c"),
            new DefaultsEmojiItem("1f433.png","","0x1f433"),
            new DefaultsEmojiItem("1f40b.png","","0x1f40b"),
            new DefaultsEmojiItem("1f404.png","","0x1f404"),
            new DefaultsEmojiItem("1f40f.png","","0x1f40f"),
            new DefaultsEmojiItem("1f400.png","","0x1f400"),
            new DefaultsEmojiItem("1f403.png","","0x1f403"),
            new DefaultsEmojiItem("1f405.png","","0x1f405"),
            new DefaultsEmojiItem("1f407.png","","0x1f407"),
            new DefaultsEmojiItem("1f409.png","","0x1f409"),
            new DefaultsEmojiItem("1f40e.png","","0x1f40e"),
            new DefaultsEmojiItem("1f410.png","","0x1f410"),
            new DefaultsEmojiItem("1f413.png","","0x1f413"),
            new DefaultsEmojiItem("1f415.png","","0x1f415"),
            new DefaultsEmojiItem("1f416.png","","0x1f416"),
            new DefaultsEmojiItem("1f401.png","","0x1f401"),
            new DefaultsEmojiItem("1f402.png","","0x1f402"),
            new DefaultsEmojiItem("1f432.png","","0x1f432"),
            new DefaultsEmojiItem("1f421.png","","0x1f421"),
            new DefaultsEmojiItem("1f40a.png","","0x1f40a"),
            new DefaultsEmojiItem("1f42b.png","","0x1f42b"),
            new DefaultsEmojiItem("1f42a.png","","0x1f42a"),
            new DefaultsEmojiItem("1f406.png","","0x1f406"),
            new DefaultsEmojiItem("1f408.png","","0x1f408"),
            new DefaultsEmojiItem("1f429.png","","0x1f429"),
            new DefaultsEmojiItem("1f43e.png","","0x1f43e"),
            new DefaultsEmojiItem("1f490.png","","0x1f490"),
            new DefaultsEmojiItem("1f338.png","","0x1f338"),
            new DefaultsEmojiItem("1f337.png","","0x1f337"),
            new DefaultsEmojiItem("1f340.png","","0x1f340"),
            new DefaultsEmojiItem("1f339.png","","0x1f339"),
            new DefaultsEmojiItem("1f33b.png","","0x1f33b"),
            new DefaultsEmojiItem("1f33a.png","","0x1f33a"),
            new DefaultsEmojiItem("1f341.png","","0x1f341"),
            new DefaultsEmojiItem("1f343.png","","0x1f343"),
            new DefaultsEmojiItem("1f342.png","","0x1f342"),
            new DefaultsEmojiItem("1f33f.png","","0x1f33f"),
            new DefaultsEmojiItem("1f33e.png","","0x1f33e"),
            new DefaultsEmojiItem("1f344.png","","0x1f344"),
            new DefaultsEmojiItem("1f335.png","","0x1f335"),
            new DefaultsEmojiItem("1f334.png","","0x1f334"),
            new DefaultsEmojiItem("1f332.png","","0x1f332"),
            new DefaultsEmojiItem("1f333.png","","0x1f333"),
            new DefaultsEmojiItem("1f330.png","","0x1f330"),
            new DefaultsEmojiItem("1f331.png","","0x1f331"),
            new DefaultsEmojiItem("1f33c.png","","0x1f33c"),
            new DefaultsEmojiItem("1f310.png","","0x1f310"),
            new DefaultsEmojiItem("1f31e.png","","0x1f31e"),
            new DefaultsEmojiItem("1f31d.png","","0x1f31d"),
            new DefaultsEmojiItem("1f31a.png","","0x1f31a"),
            new DefaultsEmojiItem("1f311.png","","0x1f311"),
            new DefaultsEmojiItem("1f312.png","","0x1f312"),
            new DefaultsEmojiItem("1f313.png","","0x1f313"),
            new DefaultsEmojiItem("1f314.png","","0x1f314"),
            new DefaultsEmojiItem("1f315.png","","0x1f315"),
            new DefaultsEmojiItem("1f316.png","","0x1f316"),
            new DefaultsEmojiItem("1f317.png","","0x1f317"),
            new DefaultsEmojiItem("1f318.png","","0x1f318"),
            new DefaultsEmojiItem("1f31c.png","","0x1f31c"),
            new DefaultsEmojiItem("1f31b.png","","0x1f31b"),
            new DefaultsEmojiItem("1f319.png","","0x1f319"),
            new DefaultsEmojiItem("1f30d.png","","0x1f30d"),
            new DefaultsEmojiItem("1f30e.png","","0x1f30e"),
            new DefaultsEmojiItem("1f30f.png","","0x1f30f"),
            new DefaultsEmojiItem("1f30b.png","","0x1f30b"),
            new DefaultsEmojiItem("1f30c.png","","0x1f30c"),
            new DefaultsEmojiItem("1f320.png","","0x1f320"),
            new DefaultsEmojiItem("2b50.png","","0x2b50", true),
            new DefaultsEmojiItem("2600.png","","0x2600", true),
            new DefaultsEmojiItem("26c5.png","","0x26c5", true),
            new DefaultsEmojiItem("2601.png","","0x2601", true),
            new DefaultsEmojiItem("26a1.png","","0x26a1", true),
            new DefaultsEmojiItem("2614.png","","0x2614", true),
            new DefaultsEmojiItem("2744.png","","0x2744", true),
            new DefaultsEmojiItem("26c4.png","","0x26c4", true),
            new DefaultsEmojiItem("1f300.png","","0x1f300"),
            new DefaultsEmojiItem("1f301.png","","0x1f301"),
            new DefaultsEmojiItem("1f308.png","","0x1f308"),
            new DefaultsEmojiItem("1f30a.png","","0x1f30a")
    };

    public EmojiPackage ToEmojiPackage() {
        EmojiPackage package = new EmojiPackage {
            Author = "system",
            AlbumCover = "pack://application:,,,/Emoji;Component/images/defaults/emoji_type_2@2x.png",
            AlbumSelectedCover = "pack://application:,,,/Emoji;Component/images/defaults/emoji_type_selected_2@2x.png",
            Title = "Nature",
            Items = new List<EmojiItem>()
        };

        package.Items.AddRange(this.items);

        return package;
    }

    /// <summary>
    /// code 和 EmojiItem 映射关系
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, EmojiItem> EmojiToIcoDictionary() {
        EmojiItem[] peopleItems = this.items.ToArray();
        Dictionary<string, EmojiItem> dic = peopleItems.ToDictionary(key =>key.Code, value => value);

        return dic;
    }

    public Dictionary<string, EmojiItem> IcoToEmojiDictionary() {
        EmojiItem[] peopleItems = this.items.ToArray();
        Dictionary<string, EmojiItem> dic = peopleItems.ToDictionary(key => key.ImgPath, value => value);

        return dic;
    }
}
}
