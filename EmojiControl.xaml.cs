using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using cn.lds.chatcore.pcw.Emoji.Entity;

namespace cn.lds.chatcore.pcw.Emoji {
/// <summary>
/// EmojiControl.xaml 的交互逻辑
/// </summary>
public partial class EmojiControl : UserControl {
    public EmojiControl() {
        InitializeComponent();

        this.MainListBox.SelectionMode = SelectionMode.Single;
    }

    private EmojiItem selectedEmojiItem = null;
    public EmojiItem SelectedEmojiItem {
        get {
            return this.selectedEmojiItem;
        }
    }

    #region 依赖属性 EmojiItems

    /// <summary>
    /// 依赖属性
    /// arg1:属性名称
    /// arg2:属性类型
    /// arg3:属性默认值
    /// arg4:属性值被改变时的回调函数
    /// </summary>
    public static readonly DependencyProperty ItemsProperty =
        DependencyProperty.Register("EmojiItems", typeof(List<EmojiItem>), typeof(EmojiControl),
                                    new PropertyMetadata(new List<EmojiItem>(), new PropertyChangedCallback(OnItemsChanged)));
    //封装依赖属性
    public List<EmojiItem> EmojiItems {
        get {
            return (List<EmojiItem>)GetValue(ItemsProperty);
        }
        set {
            SetValue(ItemsProperty, value);
        }
    }

    //回调函数
    static void OnItemsChanged(object sender, DependencyPropertyChangedEventArgs args) {
        //EmojiControl source = (EmojiControl)sender;
        //source.EmojiItems = (List<EmojiItem>)args.NewValue;
        //EmojiItemList.Clear();
        //foreach (EmojiItem item in (List<EmojiItem>)args.NewValue) {
        //    EmojiItemList.Add(item);
        //}
    }

    #endregion

    #region 事件处理
    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
        if (this.MainListBox.SelectedItems.Count > 0) {
            this.selectedEmojiItem = (EmojiItem) this.MainListBox.SelectedItems[0];
        }
    }
    #endregion

    #region 自定义路由事件
    public static readonly RoutedEvent ImgHitEvent = EventManager.RegisterRoutedEvent("ImgHit",
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(EmojiControl));
    public event RoutedEventHandler ImgHit {
        add {
            AddHandler(ImgHitEvent, value);
        }
        remove {
            RemoveHandler(ImgHitEvent, value);
        }
    }

    public void RaiseImgHitEvent(object source) {
        EmojiHitEventArgs routedEventArgs = new EmojiHitEventArgs(EmojiControl.ImgHitEvent, source) {
            TargetEmojiItem = this.selectedEmojiItem
        };
        this.RaiseEvent(routedEventArgs);//触发路由事件方法
    }
    #endregion

    private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
        RaiseImgHitEvent(e.Source);
    }
}
}
