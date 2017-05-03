using System.Windows;

namespace cn.lds.chatcore.pcw.Emoji.Entity {
public class EmojiHitEventArgs : RoutedEventArgs {
    public EmojiHitEventArgs(RoutedEvent routedEvent, object source):base(routedEvent,source) { }

    public EmojiHitEventArgs(RoutedEvent routedEvent): base(routedEvent) { }

    public EmojiItem TargetEmojiItem {
        get;
        set;
    }
}
}
