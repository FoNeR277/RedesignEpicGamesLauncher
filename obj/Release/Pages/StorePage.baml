   M S B A M L   `   `   `  ���� A  =epicRD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:epicRD.PagesepicRD.Pages  G(clr-namespace:epicRD.Attached_PropertiesepicRD.Attached_Properties      epicRD.Pages.StorePage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:epicRD.Pages     GattachedProperties(clr-namespace:epicRD.Attached_Properties       N� Title$  	StorePage�� N� 
FontFamily$ Brutal Type)� � 	Resources  �� 
TargetType   SignInPopup �� Property �� Value  PopupBackgroundBrush �� Triggers �� Binding �� RelativeSource	 �� AncestorType
 �� Mode �� Value N� EnterActions ��Name g� 
SpeedRatio �� TargetProperty	 W� To g� Duration N� ExitActions �� BeginStoryboardName��%%  &	        7  �� " ��.���  � ��$ 0����  � ��$
 5, 0q���  � ��8    ��  �� *Title+ �� $
	 PageL�$
 FindAncestor=� 	StorePage �� $ ShowSignInPopup��.���� $ 2Q�.��W� $ Height�$ 50X�$ 0:0:0.5D� �� $ ShowSignInPopup��.���  � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+��� $��0��#��[  ._���  �� Orientation$ 
Horizontal=�.+��� $��19, 0q�$��15(�$k��eYou are not signed in. To get access to all Epic Games features, reconnect to the Epic Games network.��$��Center=�  CaptionFontBrush#��[ �� -   $��
0, 2, 0, 3q�$��Sign in��  PrimaryButtonStyle#��[ � $��1�� � ColumnDefinitions �� $	��250 ��� .+��� $��Right=�$��1��  SearchBackgroundBrush#��[ � $��0�� �� $	��122 ��� $��* �.+��  � Cursor$
 Hand��$	��122�� �� $��86 ��� .+�F�   EpicIcon#��[   EpicLogoStyle#��[ $��Right=�$��Center=��� $��
Epic Games��$��1��$
��Left=�$��Center=�$��16(�
�������$��25, 0, 0, 0q�3  -epicRD.Attached_Properties.SideNavigationMenu  $��1��   MenuButtonsContainer �� $ Vertical=�.+�5  /epicRD.Attached_Properties.CheckableMenuButtons  $
��Home��  HomeIcon   Icon# [  + 'SideNavigationCheckableMenuButtonsStyle#��[   $��Store�� 	 	StoreIcon# [	 #��[   $��Library�� 
 LibraryIcon# [
 #��[   $��Unreal Engine��  UnrealEngineIcon# [ #��[ !   FooterMenuButtonsContainer �� $ Vertical=�.+�1  +epicRD.Attached_Properties.BasicMenuButtons  $��Download��  DownIcon   Icon# [  ' #SideNavigationBasicMenuButtonsStyle#��[   -     Name$ SettingButton��1   +epicRD.Attached_Properties.BasicMenuButtons   Click$ SettingButton_OnClick��$��Settings��  SettingsIcon# [ #��[   $��Offline��  OfflineIcon# [ #��[ 