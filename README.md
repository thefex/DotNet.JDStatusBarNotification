# DotNet.JDStatusBarNotification
.NET8+ iOS bindings for latest https://github.com/calimarkus/JDStatusBarNotification.git (2.2.0)

For documentation, please see above - you will find similar types under DotNet.JDStatusBarNotification namespace.

# Installation
You can install the bindings via NuGet package manager. Library has been built for .NET8, and .NET9.

Package name: iOS.JDStatusBarNotification - https://www.nuget.org/packages/iOS.JDStatusBarNotification/

# Sample usage

Initialize custom style:
```csharp
public static class AppearanceConfig
{
    public static string StatusBarNotificationErrorStyle => "error-style-key";

    public static string StatusBarNotificationSuccessStyle => "success-style-key";
    
    public static UIFont PoppinsRegular400 => UIFont.FromName(new NSString("Poppins-Regular"), 16);

    public static void Init()
    {
        JDStatusBarNotificationPresenter.SharedPresenter.AddStyleNamed(StatusBarNotificationErrorStyle, style =>
        {
            style.BackgroundStyle.BackgroundType = JDStatusBarNotificationBackgroundType.FullWidth;
            style.AnimationType = JDStatusBarNotificationAnimationType.Bounce;
            style.BackgroundStyle.BackgroundColor = UIColor.FromRGB(239, 67, 75);
            style.TextStyle.TextColor = UIColor.White;
            style.TextStyle.Font = PoppinsRegular400.WithSize(24); 
            
            return style;
        });
        
        JDStatusBarNotificationPresenter.SharedPresenter.AddStyleNamed(StatusBarNotificationSuccessStyle, style =>
        {
            style.BackgroundStyle.BackgroundType = JDStatusBarNotificationBackgroundType.FullWidth;
            style.AnimationType = JDStatusBarNotificationAnimationType.Bounce;
            style.BackgroundStyle.BackgroundColor = UIColor.FromRGB(255, 159, 28);
            style.TextStyle.TextColor = UIColor.White;
            style.TextStyle.Font = PoppinsRegular400.WithSize(24);
            
            return style;
        });
    }
}
```

Show notification:
```csharp
bool isErrorStyle = false;

var style = isErrorStyle
    ? AppearanceConfig.StatusBarNotificationErrorStyle
    : AppearanceConfig.StatusBarNotificationSuccessStyle;

JDStatusBarNotificationPresenter
    .SharedPresenter
    .PresentWithText("Hey ho bindings work!", 5.0, style);
```