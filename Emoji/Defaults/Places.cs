using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cn.lds.chatcore.pcw.Emoji.Entity;

namespace cn.lds.chatcore.pcw.Emoji.Emoji.Defaults {

public class Places : InterfaceSource {

    private readonly List<EmojiItem> items = new List<EmojiItem>() {
        new DefaultsEmojiItem("1f3e0.png","","0x1f3e0"),
            new DefaultsEmojiItem("1f3e1.png","","0x1f3e1"),
            new DefaultsEmojiItem("1f3eb.png","","0x1f3eb"),
            new DefaultsEmojiItem("1f3e2.png","","0x1f3e2"),
            new DefaultsEmojiItem("1f3e3.png","","0x1f3e3"),
            new DefaultsEmojiItem("1f3e5.png","","0x1f3e5"),
            new DefaultsEmojiItem("1f3e6.png","","0x1f3e6"),
            new DefaultsEmojiItem("1f3ea.png","","0x1f3ea"),
            new DefaultsEmojiItem("1f3e9.png","","0x1f3e9"),
            new DefaultsEmojiItem("1f3e8.png","","0x1f3e8"),
            new DefaultsEmojiItem("1f492.png","","0x1f492"),
            new DefaultsEmojiItem("26ea.png","","0x26ea", true),
            new DefaultsEmojiItem("1f3ec.png","","0x1f3ec"),
            new DefaultsEmojiItem("1f3e4.png","","0x1f3e4"),
            new DefaultsEmojiItem("1f307.png","","0x1f307"),
            new DefaultsEmojiItem("1f306.png","","0x1f306"),
            new DefaultsEmojiItem("1f3ef.png","","0x1f3ef"),
            new DefaultsEmojiItem("1f3f0.png","","0x1f3f0"),
            new DefaultsEmojiItem("26fa.png","","0x26fa", true),
            new DefaultsEmojiItem("1f3ed.png","","0x1f3ed"),
            new DefaultsEmojiItem("1f5fc.png","","0x1f5fc"),
            new DefaultsEmojiItem("1f5fe.png","","0x1f5fe"),
            new DefaultsEmojiItem("1f5fb.png","","0x1f5fb"),
            new DefaultsEmojiItem("1f304.png","","0x1f304"),
            new DefaultsEmojiItem("1f305.png","","0x1f305"),
            new DefaultsEmojiItem("1f303.png","","0x1f303"),
            new DefaultsEmojiItem("1f5fd.png","","0x1f5fd"),
            new DefaultsEmojiItem("1f309.png","","0x1f309"),
            new DefaultsEmojiItem("1f3a0.png","","0x1f3a0"),
            new DefaultsEmojiItem("1f3a1.png","","0x1f3a1"),
            new DefaultsEmojiItem("26f2.png","","0x26f2", true),
            new DefaultsEmojiItem("1f3a2.png","","0x1f3a2"),
            new DefaultsEmojiItem("1f6a2.png","","0x1f6a2"),
            new DefaultsEmojiItem("26f5.png","","0x26f5", true),
            new DefaultsEmojiItem("1f6a4.png","","0x1f6a4"),
            new DefaultsEmojiItem("1f6a3.png","","0x1f6a3"),
            new DefaultsEmojiItem("2693.png","","0x2693", true),
            new DefaultsEmojiItem("1f680.png","","0x1f680"),
            new DefaultsEmojiItem("2708.png","","0x2708", true),
            new DefaultsEmojiItem("1f4ba.png","","0x1f4ba"),
            new DefaultsEmojiItem("1f681.png","","0x1f681"),
            new DefaultsEmojiItem("1f682.png","","0x1f682"),
            new DefaultsEmojiItem("1f68a.png","","0x1f68a"),
            new DefaultsEmojiItem("1f689.png","","0x1f689"),
            new DefaultsEmojiItem("1f69e.png","","0x1f69e"),
            new DefaultsEmojiItem("1f686.png","","0x1f686"),
            new DefaultsEmojiItem("1f684.png","","0x1f684"),
            new DefaultsEmojiItem("1f685.png","","0x1f685"),
            new DefaultsEmojiItem("1f688.png","","0x1f688"),
            new DefaultsEmojiItem("1f687.png","","0x1f687"),
            new DefaultsEmojiItem("1f69d.png","","0x1f69d"),
            new DefaultsEmojiItem("1f68b.png","","0x1f68b"),
            new DefaultsEmojiItem("1f683.png","","0x1f683"),
            new DefaultsEmojiItem("1f68e.png","","0x1f68e"),
            new DefaultsEmojiItem("1f68c.png","","0x1f68c"),
            new DefaultsEmojiItem("1f68d.png","","0x1f68d"),
            new DefaultsEmojiItem("1f699.png","","0x1f699"),
            new DefaultsEmojiItem("1f698.png","","0x1f698"),
            new DefaultsEmojiItem("1f697.png","","0x1f697"),
            new DefaultsEmojiItem("1f695.png","","0x1f695"),
            new DefaultsEmojiItem("1f696.png","","0x1f696"),
            new DefaultsEmojiItem("1f69b.png","","0x1f69b"),
            new DefaultsEmojiItem("1f69a.png","","0x1f69a"),
            new DefaultsEmojiItem("1f6a8.png","","0x1f6a8"),
            new DefaultsEmojiItem("1f693.png","","0x1f693"),
            new DefaultsEmojiItem("1f694.png","","0x1f694"),
            new DefaultsEmojiItem("1f692.png","","0x1f692"),
            new DefaultsEmojiItem("1f691.png","","0x1f691"),
            new DefaultsEmojiItem("1f690.png","","0x1f690"),
            new DefaultsEmojiItem("1f6b2.png","","0x1f6b2"),
            new DefaultsEmojiItem("1f6a1.png","","0x1f6a1"),
            new DefaultsEmojiItem("1f69f.png","","0x1f69f"),
            new DefaultsEmojiItem("1f6a0.png","","0x1f6a0"),
            new DefaultsEmojiItem("1f69c.png","","0x1f69c"),
            new DefaultsEmojiItem("1f488.png","","0x1f488"),
            new DefaultsEmojiItem("1f68f.png","","0x1f68f"),
            new DefaultsEmojiItem("1f3ab.png","","0x1f3ab"),
            new DefaultsEmojiItem("1f6a6.png","","0x1f6a6"),
            new DefaultsEmojiItem("1f6a5.png","","0x1f6a5"),
            new DefaultsEmojiItem("26a0.png","","0x26a0", true),
            new DefaultsEmojiItem("1f6a7.png","","0x1f6a7"),
            new DefaultsEmojiItem("1f530.png","","0x1f530"),
            new DefaultsEmojiItem("26fd.png","","0x26fd", true),
            new DefaultsEmojiItem("1f3ee.png","","0x1f3ee"),
            new DefaultsEmojiItem("1f3b0.png","","0x1f3b0"),
            new DefaultsEmojiItem("2668.png","","0x2668", true),
            new DefaultsEmojiItem("1f5ff.png","","0x1f5ff"),
            new DefaultsEmojiItem("1f3aa.png","","0x1f3aa"),
            new DefaultsEmojiItem("1f3ad.png","","0x1f3ad"),
            new DefaultsEmojiItem("1f4cd.png","","0x1f4cd"),
            new DefaultsEmojiItem("1f6a9.png","","0x1f6a9"),
            //new DefaultsEmojiItem("\ud83c\uddef\ud83c\uddf5.png","","\ud83c\uddef\ud83c\uddf5"),
            //new DefaultsEmojiItem("\ud83c\uddf0\ud83c\uddf7.png","","\ud83c\uddf0\ud83c\uddf7"),
            //new DefaultsEmojiItem("\ud83c\udde9\ud83c\uddea.png","","\ud83c\udde9\ud83c\uddea"),
            //new DefaultsEmojiItem("\ud83c\udde8\ud83c\uddf3.png","","\ud83c\udde8\ud83c\uddf3"),
            //new DefaultsEmojiItem("\ud83c\uddfa\ud83c\uddf8.png","","\ud83c\uddfa\ud83c\uddf8"),
            //new DefaultsEmojiItem("\ud83c\uddeb\ud83c\uddf7.png","","\ud83c\uddeb\ud83c\uddf7"),
            //new DefaultsEmojiItem("\ud83c\uddea\ud83c\uddf8.png","","\ud83c\uddea\ud83c\uddf8"),
            //new DefaultsEmojiItem("\ud83c\uddee\ud83c\uddf9.png","","\ud83c\uddee\ud83c\uddf9"),
            //new DefaultsEmojiItem("\ud83c\uddf7\ud83c\uddfa.png","","\ud83c\uddf7\ud83c\uddfa"),
            //new DefaultsEmojiItem("\ud83c\uddec\ud83c\udde7.png","","\ud83c\uddec\ud83c\udde7")
            new DefaultsEmojiItem("1f1ef_1f1f5.png","","0x1f1ef_0x1f1f5"),
            new DefaultsEmojiItem("1f1fa_1f1f8.png","","0x1f1fa_0x1f1f8"),
            new DefaultsEmojiItem("1f1eb_1f1f7.png","","0x1f1eb_0x1f1f7"),
            new DefaultsEmojiItem("1f1e9_1f1ea.png","","0x1f1e9_0x1f1ea"),
            new DefaultsEmojiItem("1f1ee_1f1f9.png","","0x1f1ee_0x1f1f9"),
            new DefaultsEmojiItem("1f1ec_1f1e7.png","","0x1f1ec_0x1f1e7"),
            new DefaultsEmojiItem("1f1ea_1f1f8.png","","0x1f1ea_0x1f1f8"),
            new DefaultsEmojiItem("1f1f7_1f1fa.png","","0x1f1f7_0x1f1fa"),
            new DefaultsEmojiItem("1f1e8_1f1f3.png","","0x1f1e8_0x1f1f3"),
            new DefaultsEmojiItem("1f1f0_1f1f7.png","","0x1f1f0_0x1f1f7"),
    };

    public EmojiPackage ToEmojiPackage() {
        EmojiPackage package = new EmojiPackage {
            Author = "system",
            AlbumCover = "pack://application:,,,/Emoji;Component/images/defaults/emoji_type_4@2x.png",
            AlbumSelectedCover = "pack://application:,,,/Emoji;Component/images/defaults/emoji_type_selected_4@2x.png",
            Title = "Places",
            Items = new List<EmojiItem>()
        };
        package.Items.AddRange(this.items);

        return package;
    }

    public Dictionary<string, EmojiItem> EmojiToIcoDictionary() {
        EmojiItem[] placesItems = this.items.ToArray();
        Dictionary<string, EmojiItem> dic = placesItems.ToDictionary(key => key.Code, value => value);

        return dic;
    }

    public Dictionary<string, EmojiItem> IcoToEmojiDictionary() {
        EmojiItem[] placesItems = this.items.ToArray();
        Dictionary<string, EmojiItem> dic = placesItems.ToDictionary(key => key.ImgPath, value => value);

        return dic;
    }
}
}
