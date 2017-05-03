using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.lds.chatcore.pcw.Emoji.Entity {
/// <summary>
/// 单词的类型（文字，表情，图片，换行）
/// </summary>
public enum WordType {
    /// <summary>
    /// 文字
    /// </summary>
    Text,
    /// <summary>
    /// 表情
    /// </summary>
    Emoji,
    /// <summary>
    /// 图片
    /// </summary>
    Image,
    /// <summary>
    /// 换行
    /// </summary>
    Wrap
}
}
