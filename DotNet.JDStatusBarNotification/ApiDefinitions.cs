using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Security;
using UIKit; 

namespace DotNet.JDStatusBarNotification
{
// @interface JDStatusBarNotificationPresenter : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface JDStatusBarNotificationPresenter
	{
		// @property (readonly, nonatomic, strong, class) JDStatusBarNotificationPresenter * _Nonnull sharedPresenter;
		[Static]
		[Export("sharedPresenter", ArgumentSemantic.Strong)]
		JDStatusBarNotificationPresenter SharedPresenter { get; }

		// -(UIView * _Nonnull)presentWithCustomView:(UIView * _Nonnull)customView sizingController:(id<JDStatusBarNotificationPresenterCustomViewSizingController> _Nullable)sizingController styleName:(NSString * _Nullable)styleName completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))completion;
		[Export("presentWithCustomView:sizingController:styleName:completion:")]
		UIView PresentWithCustomView(UIView customView, [NullAllowed] JDStatusBarNotificationPresenterCustomViewSizingController sizingController, [NullAllowed] string styleName, [NullAllowed] Action<JDStatusBarNotificationPresenter> completion);

		// -(void)updateDefaultStyle:(JDStatusBarNotificationStyle * _Nonnull (^ _Nonnull)(JDStatusBarNotificationStyle * _Nonnull))prepare;
		[Export("updateDefaultStyle:")]
		void UpdateDefaultStyle(Func<JDStatusBarNotificationStyle, JDStatusBarNotificationStyle> prepare);

		// -(NSString * _Nonnull)addStyleNamed:(NSString * _Nonnull)name basedOnStyle:(enum JDStatusBarNotificationIncludedStyle)includedStyle prepare:(JDStatusBarNotificationStyle * _Nonnull (^ _Nonnull)(JDStatusBarNotificationStyle * _Nonnull))prepare;
		[Export("addStyleNamed:basedOnStyle:prepare:")]
		string AddStyleNamed(string name, JDStatusBarNotificationIncludedStyle includedStyle, Func<JDStatusBarNotificationStyle, JDStatusBarNotificationStyle> prepare);

		// -(void)displayProgressBarWithPercentage:(double)percentage;
		[Export("displayProgressBarWithPercentage:")]
		void DisplayProgressBarWithPercentage(double percentage);

		// -(void)animateProgressBarToPercentage:(double)percentage animationDuration:(double)duration completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))completion;
		[Export("animateProgressBarToPercentage:animationDuration:completion:")]
		void AnimateProgressBarToPercentage(double percentage, double duration, [NullAllowed] Action<JDStatusBarNotificationPresenter> completion);

		// -(void)displayActivityIndicator:(BOOL)show;
		[Export("displayActivityIndicator:")]
		void DisplayActivityIndicator(bool show);

		// -(void)displayLeftView:(UIView * _Nullable)leftView;
		[Export("displayLeftView:")]
		void DisplayLeftView([NullAllowed] UIView leftView);

		// -(void)updateText:(NSString * _Nonnull)title;
		[Export("updateText:")]
		void UpdateText(string title);

		// -(void)updateSubtitle:(NSString * _Nullable)subtitle;
		[Export("updateSubtitle:")]
		void UpdateSubtitle([NullAllowed] string subtitle);

		// @property (readonly, nonatomic) BOOL isVisible;
		[Export("isVisible")] bool IsVisible { get; }

		// -(void)setWindowScene:(UIWindowScene * _Nullable)windowScene;
		[Export("setWindowScene:")]
		void SetWindowScene([NullAllowed] UIWindowScene windowScene);
	}

// @interface JDStatusBarNotification_Swift_445 (JDStatusBarNotificationPresenter)
	[Category]
	[BaseType(typeof(JDStatusBarNotificationPresenter))]
	interface JDStatusBarNotificationPresenter_JDStatusBarNotification_Swift_445
	{
		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t;
		[Export("presentWithText:")]
		UIView PresentWithText(string t);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("presentWithText:completion:")]
		UIView PresentWithText(string t, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(UIView * _Nonnull)presentWithTitle:(NSString * _Nonnull)t subtitle:(NSString * _Nonnull)st completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("presentWithTitle:subtitle:completion:")]
		UIView PresentWithTitle(string t, string st, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t dismissAfterDelay:(double)d;
		[Export("presentWithText:dismissAfterDelay:")]
		UIView PresentWithText(string t, double d);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t customStyle:(NSString * _Nonnull)cu;
		[Export("presentWithText:customStyle:")]
		UIView PresentWithText(string t, string cu);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t customStyle:(NSString * _Nullable)cu completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("presentWithText:customStyle:completion:")]
		UIView PresentWithText(string t, [NullAllowed] string cu, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(UIView * _Nonnull)presentWithTitle:(NSString * _Nonnull)t subtitle:(NSString * _Nullable)st customStyle:(NSString * _Nullable)cu completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("presentWithTitle:subtitle:customStyle:completion:")]
		UIView PresentWithTitle(string t, [NullAllowed] string st, [NullAllowed] string cu, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t dismissAfterDelay:(double)d customStyle:(NSString * _Nonnull)cu;
		[Export("presentWithText:dismissAfterDelay:customStyle:")]
		UIView PresentWithText(string t, double d, string cu);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t includedStyle:(enum JDStatusBarNotificationIncludedStyle)s;
		[Export("presentWithText:includedStyle:")]
		UIView PresentWithText(string t, JDStatusBarNotificationIncludedStyle s);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t includedStyle:(enum JDStatusBarNotificationIncludedStyle)s completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("presentWithText:includedStyle:completion:")]
		UIView PresentWithText(string t, JDStatusBarNotificationIncludedStyle s, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(UIView * _Nonnull)presentWithTitle:(NSString * _Nonnull)t subtitle:(NSString * _Nullable)st includedStyle:(enum JDStatusBarNotificationIncludedStyle)s completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("presentWithTitle:subtitle:includedStyle:completion:")]
		UIView PresentWithTitle(string t, [NullAllowed] string st, JDStatusBarNotificationIncludedStyle s, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(UIView * _Nonnull)presentWithText:(NSString * _Nonnull)t dismissAfterDelay:(double)d includedStyle:(enum JDStatusBarNotificationIncludedStyle)s;
		[Export("presentWithText:dismissAfterDelay:includedStyle:")]
		UIView PresentWithText(string t, double d, JDStatusBarNotificationIncludedStyle s);

		// -(UIView * _Nonnull)presentWithCustomView:(UIView * _Nonnull)cv styleName:(NSString * _Nullable)s completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("presentWithCustomView:styleName:completion:")]
		UIView PresentWithCustomView(UIView cv, [NullAllowed] string s, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(void)dismiss;
		[Export("dismiss")]
		void Dismiss();

		// -(void)dismissWithCompletion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("dismissWithCompletion:")]
		void DismissWithCompletion([NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(void)dismissAnimated:(BOOL)a;
		[Export("dismissAnimated:")]
		void DismissAnimated(bool a);

		// -(void)dismissAfterDelay:(double)d;
		[Export("dismissAfterDelay:")]
		void DismissAfterDelay(double d);

		// -(void)dismissAfterDelay:(double)d completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("dismissAfterDelay:completion:")]
		void DismissAfterDelay(double d, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(void)dismissAnimated:(BOOL)a afterDelay:(double)d completion:(void (^ _Nullable)(JDStatusBarNotificationPresenter * _Nonnull))c;
		[Export("dismissAnimated:afterDelay:completion:")]
		void DismissAnimated(bool a, double d, [NullAllowed] Action<JDStatusBarNotificationPresenter> c);

		// -(NSString * _Nonnull)addStyleNamed:(NSString * _Nonnull)n prepare:(JDStatusBarNotificationStyle * _Nonnull (^ _Nonnull)(JDStatusBarNotificationStyle * _Nonnull))p;
		[Export("addStyleNamed:prepare:")]
		string AddStyleNamed(string n, Func<JDStatusBarNotificationStyle, JDStatusBarNotificationStyle> p);
	}

// @protocol JDStatusBarNotificationPresenterCustomViewSizingController
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Model]
	[BaseType(typeof(NSObject))]
	interface JDStatusBarNotificationPresenterCustomViewSizingController
	{
		// @required -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Abstract]
		[Export("sizeThatFits:")]
		CGSize SizeThatFits(CGSize size);
	}

// @interface JDStatusBarNotificationBackgroundStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface JDStatusBarNotificationBackgroundStyle
	{
		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) enum JDStatusBarNotificationBackgroundType backgroundType;
		[Export("backgroundType", ArgumentSemantic.Assign)]
		JDStatusBarNotificationBackgroundType BackgroundType { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationPillStyle * _Nonnull pillStyle;
		[Export("pillStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationPillStyle PillStyle { get; set; }
	}

// @interface JDStatusBarNotificationLeftViewStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface JDStatusBarNotificationLeftViewStyle
	{
		// @property (nonatomic) double spacing;
		[Export("spacing")] double Spacing { get; set; }

		// @property (nonatomic) double offsetX __attribute__((deprecated("", "offset")));
		[Export("offsetX")] double OffsetX { get; set; }

		// @property (nonatomic) CGPoint offset;
		[Export("offset", ArgumentSemantic.Assign)]
		CGPoint Offset { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable tintColor;
		[NullAllowed, Export("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// @property (nonatomic) enum JDStatusBarNotificationLeftViewAlignment alignment;
		[Export("alignment", ArgumentSemantic.Assign)]
		JDStatusBarNotificationLeftViewAlignment Alignment { get; set; }
	}

// @interface JDStatusBarNotificationPillStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface JDStatusBarNotificationPillStyle
	{
		// @property (nonatomic) double height;
		[Export("height")] double Height { get; set; }

		// @property (nonatomic) double topSpacing;
		[Export("topSpacing")] double TopSpacing { get; set; }

		// @property (nonatomic) double minimumWidth;
		[Export("minimumWidth")] double MinimumWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable borderColor;
		[NullAllowed, Export("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) double borderWidth;
		[Export("borderWidth")] double BorderWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable shadowColor;
		[NullAllowed, Export("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @property (nonatomic) double shadowRadius;
		[Export("shadowRadius")] double ShadowRadius { get; set; }

		// @property (nonatomic) CGSize shadowOffset __attribute__((deprecated("", "shadowOffsetXY")));
		[Export("shadowOffset", ArgumentSemantic.Assign)]
		CGSize ShadowOffset { get; set; }

		// @property (nonatomic) CGPoint shadowOffsetXY;
		[Export("shadowOffsetXY", ArgumentSemantic.Assign)]
		CGPoint ShadowOffsetXY { get; set; }
	}

// @interface JDStatusBarNotificationProgressBarStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface JDStatusBarNotificationProgressBarStyle
	{
		// @property (nonatomic, strong) UIColor * _Nullable barColor;
		[NullAllowed, Export("barColor", ArgumentSemantic.Strong)]
		UIColor BarColor { get; set; }

		// @property (nonatomic) double barHeight;
		[Export("barHeight")] double BarHeight { get; set; }

		// @property (nonatomic) enum JDStatusBarNotificationProgressBarPosition position;
		[Export("position", ArgumentSemantic.Assign)]
		JDStatusBarNotificationProgressBarPosition Position { get; set; }

		// @property (nonatomic) double horizontalInsets;
		[Export("horizontalInsets")] double HorizontalInsets { get; set; }

		// @property (nonatomic) double offsetY;
		[Export("offsetY")] double OffsetY { get; set; }

		// @property (nonatomic) double cornerRadius;
		[Export("cornerRadius")] double CornerRadius { get; set; }
	}

// @interface JDStatusBarNotificationStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface JDStatusBarNotificationStyle
	{
		// @property (nonatomic, strong) JDStatusBarNotificationTextStyle * _Nonnull textStyle;
		[Export("textStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationTextStyle TextStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationTextStyle * _Nonnull subtitleStyle;
		[Export("subtitleStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationTextStyle SubtitleStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationBackgroundStyle * _Nonnull backgroundStyle;
		[Export("backgroundStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationBackgroundStyle BackgroundStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationProgressBarStyle * _Nonnull progressBarStyle;
		[Export("progressBarStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationProgressBarStyle ProgressBarStyle { get; set; }

		// @property (nonatomic, strong) JDStatusBarNotificationLeftViewStyle * _Nonnull leftViewStyle;
		[Export("leftViewStyle", ArgumentSemantic.Strong)]
		JDStatusBarNotificationLeftViewStyle LeftViewStyle { get; set; }

		// @property (nonatomic) enum JDStatusBarNotificationSystemBarStyle systemStatusBarStyle;
		[Export("systemStatusBarStyle", ArgumentSemantic.Assign)]
		JDStatusBarNotificationSystemBarStyle SystemStatusBarStyle { get; set; }

		// @property (nonatomic) enum JDStatusBarNotificationAnimationType animationType;
		[Export("animationType", ArgumentSemantic.Assign)]
		JDStatusBarNotificationAnimationType AnimationType { get; set; }

		// @property (nonatomic) BOOL canSwipeToDismiss;
		[Export("canSwipeToDismiss")] bool CanSwipeToDismiss { get; set; }

		// @property (nonatomic) BOOL canTapToHold;
		[Export("canTapToHold")] bool CanTapToHold { get; set; }

		// @property (nonatomic) BOOL canDismissDuringUserInteraction;
		[Export("canDismissDuringUserInteraction")]
		bool CanDismissDuringUserInteraction { get; set; }
	}

// @interface JDStatusBarNotificationTextStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface JDStatusBarNotificationTextStyle
	{
		// -(instancetype _Nonnull)initWithTextColor:(UIColor * _Nullable)textColor font:(UIFont * _Nullable)font __attribute__((objc_designated_initializer));
		[Export("initWithTextColor:font:")]
		[DesignatedInitializer]
		NativeHandle Constructor([NullAllowed] UIColor textColor, [NullAllowed] UIFont font);

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("", "shadowColor") UIColor * textShadowColor __attribute__((deprecated("", "shadowColor")));
		[Export("textShadowColor", ArgumentSemantic.Strong)]
		UIColor TextShadowColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable shadowColor;
		[NullAllowed, Export("shadowColor", ArgumentSemantic.Strong)]
		UIColor ShadowColor { get; set; }

		// @property (nonatomic) CGSize textShadowOffset __attribute__((deprecated("", "shadowOffset")));
		[Export("textShadowOffset", ArgumentSemantic.Assign)]
		CGSize TextShadowOffset { get; set; }

		// @property (nonatomic) CGPoint shadowOffset;
		[Export("shadowOffset", ArgumentSemantic.Assign)]
		CGPoint ShadowOffset { get; set; }

		// @property (nonatomic) double textOffsetY;
		[Export("textOffsetY")] double TextOffsetY { get; set; }
	}
}