using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using Doit.Chat.Emoji.Emoji.Defaults;
using Doit.Chat.Emoji.Entity;

namespace Doit.Chat.Emoji {

/// <summary>
/// 解析Emoji的帮助类
/// </summary>
public class EmojiHelper {

    /// <summary>
    /// 通过图标路径获得表情的UTF字符串
    /// 该字符串可以直接发送给IOS 和 Android
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static string ConvertEmojiToString(string url) {
        string emojiString = string.Empty;
        EmojiItem emojiItem = null;
        if (DefaultsEmojis.Instance.IcoToEmojiDictionary.TryGetValue(url, out emojiItem)) {
            if (emojiItem != null) {
                string[] codeArr = emojiItem.Code.Split('_');
                foreach (string subCode in codeArr) {
                    if (((DefaultsEmojiItem) emojiItem).IsShort) {
                        emojiString += EmojiHelper.ShortToUtf16String(subCode.Replace("0x", ""));
                    } else {
                        emojiString += EmojiHelper.Int32ToUtf16String(subCode.Replace("0x", ""));
                    }
                }
                return emojiString;
            }
        }

        return String.Empty;
    }

/// <summary>
/// 通过表情的UTF字符串，取得表情图标的路径
/// </summary>
/// <param name="code"></param>
/// <returns></returns>
    public static string GetEmojiIcoPath(string code) {
        EmojiItem emojiItem = null;
        if (DefaultsEmojis.Instance.EmojiToIcoDictionary.TryGetValue(code, out emojiItem)) {
            return emojiItem.ImgPath;
        }

        return string.Empty;
    }


    /// <summary>
    /// EmoJi U+字符串对应的 int 值 转换成UTF16字符编码的值
    /// </summary>
    /// <param name="v">EmojiU+1F604 转成计算机整形以后的值V=0x1F604 </param>
    /// <param name="lowHeight">低字节在前的顺序.(默认)</param>
    /// <remarks>
    ///参考
    ///http://blog.csdn.net/fengsh998/article/details/8668002
    ///http://punchdrunker.github.io/iOSEmoji/table_html/index.html
    /// v  = 0x64321
    /// Vx = v - 0x10000
    ///    = 0x54321
    ///    = 0101 0100 0011 0010 0001
    ///
    /// Vh = 01 0101 0000 // Vx 的高位部份的 10 bits
    /// Vl = 11 0010 0001 // Vx 的低位部份的 10 bits
    /// wh = 0xD800 //結果的前16位元初始值
    /// wl = 0xDC00 //結果的後16位元初始值
    ///
    /// wh = wh | Vh
    ///    = 1101 1000 0000 0000
    ///    |        01 0101 0000
    ///    = 1101 1001 0101 0000
    ///    = 0xD950
    ///
    /// wl = wl | Vl
    ///    = 1101 1100 0000 0000
    ///    |        11 0010 0001
    ///    = 1101 1111 0010 0001
    ///    = 0xDF21
    /// </remarks>
    /// <returns>EMOJI字符对应的UTF16编码16进制整形表示</returns>
    public static Int32 EmojiToUtf16(Int32 v, bool lowHeight = true) {

        Int32 Vx = v - 0x10000;

        Int32 Vh = Vx >> 10;//取高10位部分
        Int32 Vl = Vx & 0x3ff; //取低10位部分

        Int32 wh = 0xD800; //結果的前16位元初始值,这个地方应该是根据Unicode的编码规则总结出来的数值.
        Int32 wl = 0xDC00; //結果的後16位元初始值,这个地方应该是根据Unicode的编码规则总结出来的数值.
        wh = wh | Vh;
        wl = wl | Vl;
        if (lowHeight) {
            return wl << 16 | wh;   //低位左移16位以后再把高位合并起来 得到的结果是UTF16的编码值   //适合低位在前的操作系统
        } else {
            return wh << 16 | wl; //高位左移16位以后再把低位合并起来 得到的结果是UTF16的编码值   //适合高位在前的操作系统
        }
    }

    /// <summary>
    /// 字符串形式的 Emoji 16进制Unicode编码  转换成 UTF16字符串 能够直接输出到客户端
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public static string Int32ToUtf16String(string code) {
        if (code.Length != 4 && code.Length != 5) {
            throw new ArgumentException("错误的 code 16进制数据长度.一般为4位或5位");
        }
        //1f604
        int unicodeHex = int.Parse(code, System.Globalization.NumberStyles.HexNumber);
        //1f604对应 utf16 编码的int
        Int32 utf16Hex = EmojiToUtf16(unicodeHex, true);             //这里字符的低位在前.高位在后.
        var emojiBytes = BitConverter.GetBytes(utf16Hex);                     //把整型值变成Byte[]形式. Int64的话 丢掉高位的空白0000000

        return Encoding.Unicode.GetString(emojiBytes);
    }

    public static string ShortToUtf16String(string code) {
        if (code.Length != 4 && code.Length != 5) {
            throw new ArgumentException("错误的 code 16进制数据长度.一般为4位或5位");
        }
        //1f604
        short unicodeHex = short.Parse(code, NumberStyles.HexNumber);
        //1f604对应 utf16 编码的int
        var emojiBytes = BitConverter.GetBytes(unicodeHex);

        return Encoding.Unicode.GetString(emojiBytes);
    }

    public static string Unicode2String(string source) {
        //string str = "//u4e2d//u6587";
        string outStr = "";
        if (!string.IsNullOrEmpty(source)) {
            string[] strlist = source.Replace("//", "").Split('u');
            try {
                for (int i = 1; i < strlist.Length; i++) {
                    //将unicode字符转为10进制整数，然后转为char中文字符
                    outStr += (char) int.Parse(strlist[i], System.Globalization.NumberStyles.HexNumber);
                }
            } catch (FormatException ex) {
                outStr = ex.Message;
            }
        }
        return outStr;
    }



    /// <summary>
    /// 把包含表情的字符串中的表情替换为表情图片
    /// </summary>
    /// <param name="text">文本消息内容</param>
    /// <param name="txtBlock">显示消息控件</param>
    /// <param name="imgWidth">表情图标的宽度</param>
    /// <param name="imgHeight">表情图标的高度</param>
    public static void ReplaceEmojiToIco(string text, TextBlock txtBlock, int imgWidth = 24, int imgHeight = 24) {
        if (null  == txtBlock) {
            return;
        }
        txtBlock.Inlines.Clear();

        int skip;
        int textLengthToProcess = text.Length;
        StringBuilder textBuilder = new StringBuilder(); // 文字消息
        for (int i = 0; i < text.Length; i += skip) {
            skip = 0;
            string icon = string.Empty;
            int unicode = char.ConvertToUtf32(text, i);
            skip = char.IsSurrogatePair(text, i) ? 2 : 1;
            if (unicode > 0xff) {
                icon = "0x" + unicode.ToString("x2");
                if (!DefaultsEmojis.Instance.EmojiToIcoDictionary.ContainsKey(icon)) {
                    icon = string.Empty;
                }
            }
            if (icon.Equals(string.Empty) && i + skip < textLengthToProcess) {
                int followUnicode = char.ConvertToUtf32(text, i + skip);
                if (followUnicode == 0x20e3) {
                    int followSkip = char.IsSurrogatePair(text, i + skip) ? 2 : 1;
                    if ((unicode >= 0x0030 && unicode <= 0x0039) || 0x0023 == unicode) {
                        icon = "0x" + unicode.ToString("x2") + "_0x20e3";
                    } else {
                        followSkip = 0;
                    }
                    skip += followSkip;
                } else {
                    int followSkip = char.IsSurrogatePair(text, i + skip) ? 2 : 1;
                    switch (unicode) {
                    case 0x1f1ef:
                        icon = (followUnicode == 0x1f1f5) ? "0x1f1ef_0x1f1f5"
                               : string.Empty;
                        break;
                    case 0x1f1fa:
                        icon = (followUnicode == 0x1f1f8) ? "0x1f1fa_0x1f1f8"
                               : string.Empty;
                        break;
                    case 0x1f1eb:
                        icon = (followUnicode == 0x1f1f7) ? "0x1f1eb_0x1f1f7"
                               : string.Empty;
                        break;
                    case 0x1f1e9:
                        icon = (followUnicode == 0x1f1ea) ? "0x1f1e9_0x1f1ea"
                               : string.Empty;
                        break;
                    case 0x1f1ee:
                        icon = (followUnicode == 0x1f1f9) ? "0x1f1ee_0x1f1f9"
                               : string.Empty;
                        break;
                    case 0x1f1ec:
                        icon = (followUnicode == 0x1f1e7) ? "0x1f1ec_0x1f1e7"
                               : string.Empty;
                        break;
                    case 0x1f1ea:
                        icon = (followUnicode == 0x1f1f8) ? "0x1f1ea_0x1f1f8"
                               : string.Empty;
                        break;
                    case 0x1f1f7:
                        icon = (followUnicode == 0x1f1fa) ? "0x1f1f7_0x1f1fa"
                               : string.Empty;
                        break;
                    case 0x1f1e8:
                        icon = (followUnicode == 0x1f1f3) ? "0x1f1e8_0x1f1f3"
                               : string.Empty;
                        break;
                    case 0x1f1f0:
                        icon = (followUnicode == 0x1f1f7) ? "0x1f1f0_0x1f1f7"
                               : string.Empty;
                        break;
                    default:
                        followSkip = 0;
                        break;
                    }
                    skip += followSkip;
                }
            }
            //}

            if (!icon.Equals(string.Empty)) {
                // 表情符号的场合
                EmojiItem emojiItem = null;
                if (DefaultsEmojis.Instance.EmojiToIcoDictionary.TryGetValue(icon, out emojiItem)) {
                    string iconPath = emojiItem.ImgPath;
                    if (textBuilder.Length > 0) {
                        // 把表情符号前面的文字创建出来
                        Run textrRun = new Run();
                        textrRun.Text = textBuilder.ToString();
                        txtBlock.Inlines.Add(textrRun);
                        textBuilder.Clear();
                    }
                    // 找到表情图标，创建表情控件
                    Image imgMessage = new Image();
                    imgMessage.Width = imgWidth;
                    imgMessage.Height = imgHeight;
                    BitmapImage bImg = new BitmapImage();
                    imgMessage.IsEnabled = true;
                    bImg.BeginInit();
                    bImg.UriSource = new Uri(iconPath, UriKind.RelativeOrAbsolute);
                    bImg.EndInit();
                    imgMessage.Source = bImg;
                    InlineUIContainer iuc = new InlineUIContainer(imgMessage);
                    txtBlock.Inlines.Add(iuc);
                } else {
                    // 没有找到表情图标,直接当作普通字符输出
                    textBuilder.Append(text.Substring(i, skip));
                }
            } else {
                // 普通文字的场合
                string currChar = text.Substring(i, 1);
                if (currChar.Equals(Environment.NewLine)) {
                    // 换行符的场合
                    if (textBuilder.Length > 0) {
                        // 生成前面的文字
                        Run textrRun = new Run();
                        textrRun.Text = textBuilder.ToString();
                        txtBlock.Inlines.Add(textrRun);
                        textBuilder.Clear();
                    }
                    // 生成换行
                    LineBreak lineBreak = new LineBreak();
                    txtBlock.Inlines.Add(lineBreak);
                } else {
                    // 除换行符意外的普通文字
                    textBuilder.Append(text.Substring(i, 1));
                }
            }
        }
        if (textBuilder.Length > 0) {
            // 生成前面的文字
            Run textrRun = new Run();
            textrRun.Text = textBuilder.ToString();
            txtBlock.Inlines.Add(textrRun);
            textBuilder.Clear();
        }
    }


    /// <summary>
    /// 把包含表情的字符串进行解析
    /// </summary>
    /// <param name="text">文本消息内容</param>
    public static List<WordItem> ConvertTextToEmoji(string text) {

        List<WordItem> wordsList = new List<WordItem>();
        int skip;
        int textLengthToProcess = text.Length;
        if (textLengthToProcess == 0) {
            return null;
        }
        StringBuilder textBuilder = new StringBuilder(); // 文字消息
        for (int i = 0; i < text.Length; i += skip) {
            skip = 0;
            string icon = string.Empty;
            int unicode = char.ConvertToUtf32(text, i);
            skip = char.IsSurrogatePair(text, i) ? 2 : 1;
            if (unicode > 0xff) {
                icon = "0x" + unicode.ToString("x2");
                if (!DefaultsEmojis.Instance.EmojiToIcoDictionary.ContainsKey(icon)) {
                    icon = string.Empty;
                }
            }
            if (icon.Equals(string.Empty) && i + skip < textLengthToProcess) {
                int followUnicode = char.ConvertToUtf32(text, i + skip);
                if (followUnicode == 0x20e3) {
                    int followSkip = char.IsSurrogatePair(text, i + skip) ? 2 : 1;
                    if ((unicode >= 0x0030 && unicode <= 0x0039) || 0x0023 == unicode) {
                        icon = "0x" + unicode.ToString("x2") + "_0x20e3";
                    } else {
                        followSkip = 0;
                    }
                    skip += followSkip;
                } else {
                    int followSkip = char.IsSurrogatePair(text, i + skip) ? 2 : 1;
                    switch (unicode) {
                    case 0x1f1ef:
                        icon = (followUnicode == 0x1f1f5) ? "0x1f1ef_0x1f1f5"
                               : string.Empty;
                        break;
                    case 0x1f1fa:
                        icon = (followUnicode == 0x1f1f8) ? "0x1f1fa_0x1f1f8"
                               : string.Empty;
                        break;
                    case 0x1f1eb:
                        icon = (followUnicode == 0x1f1f7) ? "0x1f1eb_0x1f1f7"
                               : string.Empty;
                        break;
                    case 0x1f1e9:
                        icon = (followUnicode == 0x1f1ea) ? "0x1f1e9_0x1f1ea"
                               : string.Empty;
                        break;
                    case 0x1f1ee:
                        icon = (followUnicode == 0x1f1f9) ? "0x1f1ee_0x1f1f9"
                               : string.Empty;
                        break;
                    case 0x1f1ec:
                        icon = (followUnicode == 0x1f1e7) ? "0x1f1ec_0x1f1e7"
                               : string.Empty;
                        break;
                    case 0x1f1ea:
                        icon = (followUnicode == 0x1f1f8) ? "0x1f1ea_0x1f1f8"
                               : string.Empty;
                        break;
                    case 0x1f1f7:
                        icon = (followUnicode == 0x1f1fa) ? "0x1f1f7_0x1f1fa"
                               : string.Empty;
                        break;
                    case 0x1f1e8:
                        icon = (followUnicode == 0x1f1f3) ? "0x1f1e8_0x1f1f3"
                               : string.Empty;
                        break;
                    case 0x1f1f0:
                        icon = (followUnicode == 0x1f1f7) ? "0x1f1f0_0x1f1f7"
                               : string.Empty;
                        break;
                    default:
                        followSkip = 0;
                        break;
                    }
                    skip += followSkip;
                }
            }

            if (!icon.Equals(string.Empty)) {
                // 表情符号的场合
                EmojiItem emojiItem = null;
                if (DefaultsEmojis.Instance.EmojiToIcoDictionary.TryGetValue(icon, out emojiItem)) {
                    string iconPath = emojiItem.ImgPath;
                    if (textBuilder.Length > 0) {
                        // 把表情符号前面的文字创建出来
                        WordItem txtItem = new WordItem();
                        txtItem.Type = WordType.Text;
                        txtItem.Content = textBuilder.ToString();
                        wordsList.Add(txtItem);
                        textBuilder.Clear();
                    }
                    // 找到表情图标，创建表情控件
                    WordItem imgItem = new WordItem();
                    imgItem.Type = WordType.Emoji;
                    imgItem.Content = iconPath;
                    wordsList.Add(imgItem);
                } else {
                    // 没有找到表情图标,直接当作普通字符输出
                    textBuilder.Append(text.Substring(i, skip));
                }
            } else {
                // 普通文字的场合
                string currChar = text.Substring(i, 1);
                if (currChar.Equals(Environment.NewLine)) {
                    // 换行符的场合
                    if (textBuilder.Length > 0) {
                        // 生成前面的文字
                        WordItem txtItem = new WordItem();
                        txtItem.Type = WordType.Text;
                        txtItem.Content = textBuilder.ToString();
                        wordsList.Add(txtItem);
                        textBuilder.Clear();
                    }
                    // 生成换行
                    LineBreak lineBreak = new LineBreak();
                    WordItem warpItem = new WordItem();
                    warpItem.Type = WordType.Wrap;
                    warpItem.Content = string.Empty;
                    wordsList.Add(warpItem);
                } else {
                    // 除换行符意外的普通文字
                    textBuilder.Append(text.Substring(i, 1));
                }
            }
        }
        if (textBuilder.Length > 0) {
            // 生成前面的文字
            WordItem txtItem = new WordItem();
            txtItem.Type = WordType.Text;
            txtItem.Content = textBuilder.ToString();
            wordsList.Add(txtItem);
            textBuilder.Clear();
        }

        return wordsList;
    }
}
}
