using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.lds.chatcore.pcw.Emoji.Entity {

/// <summary>
/// 文本串中的单词项目
/// </summary>
public class WordItem {

    /// <summary>
    /// 单词类型
    /// </summary>
    public WordType Type {
        set;
        get;
    }

    /// <summary>
    /// 单词内容
    /// 类型是文字：文字内容
    /// 类型是Emoji：表情对应的图标的相对路径
    /// 类型是Image：图片的相对路径
    /// 类型是Warp：空白
    /// </summary>
    public string Content {
        set;
        get;
    }
}
}
