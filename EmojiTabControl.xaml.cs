using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using cn.lds.chatcore.pcw.Emoji.Emoji.Defaults;
using cn.lds.chatcore.pcw.Emoji.Entity;

namespace cn.lds.chatcore.pcw.Emoji {
/// <summary>
/// EmojiTabControl.xaml 的交互逻辑
/// </summary>
public partial class EmojiTabControl : UserControl, INotifyPropertyChanged {

    //private static readonly EmojiTabControl instance = null;
    //static EmojiTabControl() {
    //    instance = new EmojiTabControl();
    //}
    //public static EmojiTabControl Instance {
    //    get {
    //        return instance;
    //    }
    //}

    public EmojiTabControl() {
        InitializeComponent();
        //new Thread(p => {
        InitDefaultsEmoji();
        //}).Start();

        this.DataContext = this;
    }

    private static ObservableCollection<EmojiPackage> emojiPackages = new ObservableCollection<EmojiPackage>();
    /// <summary>
    /// emoji集合
    /// </summary>
    public static ObservableCollection<EmojiPackage> EmojiPackages {
        get {
            return emojiPackages;
        }

        set {
            emojiPackages = value;
        }
    }

    #region INotifyPropertyChanged Members
    //属性的监听事件
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName) {
        if (string.IsNullOrEmpty(propertyName)) throw new ArgumentNullException("propertyName");
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

    #region 事件处理
    private void emojiTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        EmojiPackage selectedPackage =(EmojiPackage) emojiTabControl.SelectedItem;
        OnPropertyChanged("EmojiPackages.EmojiItems");
    }

    #endregion

    /// <summary>
    /// 选择表情后的事件处理
    /// </summary>
    /// <param name="handler"></param>
    public void SetEmojiHitEvent(RoutedEventHandler handler) {
        this.emojiTabControl.AddHandler(EmojiControl.ImgHitEvent, handler);
    }

    #region 私有方法

    public void InitDefaultsEmoji() {
        this.Dispatcher.BeginInvoke(new Action(() => {
            if (EmojiTabControl.EmojiPackages.Where(x => x.Title.Equals("默认表情")).Count() > 0)
                return;
            //EmojiPackage defaultEmojiPackage = new EmojiPackage();

            //defaultEmojiPackage.AlbumCover = "pack://application:,,,/Emoji;Component/images/defaults/emoji_1f600.png";
            //defaultEmojiPackage.Author = "system";
            //defaultEmojiPackage.Title = "默认表情";
            //defaultEmojiPackage.Items = new List<EmojiItem>();

            DefaultsEmojis.Instance.SourceList.ForEach(q => {
                EmojiTabControl.EmojiPackages.Add(q.ToEmojiPackage());
            });
            //People.Items.ForEach(item => {
            //    defaultEmojiPackage.Items.Add(item);
            //});

            //Nature.Items.ForEach(item => {
            //    defaultEmojiPackage.Items.Add(item);
            //});

            //Objects.Items.ForEach(item => {
            //    defaultEmojiPackage.Items.Add(item);
            //});

            //Places.Items.ForEach(item => {
            //    defaultEmojiPackage.Items.Add(item);
            //});

            //Symbols.Items.ForEach(item => {
            //    defaultEmojiPackage.Items.Add(item);
            //});

            //EmojiTabControl.EmojiPackages.Add(defaultEmojiPackage);

        }), null);
    }
    #endregion
}
}
