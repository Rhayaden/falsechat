   M S B A M L   `   `   `  ����D  @Falsechat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Falsechat.ViewFalsechat.View  5      ;"clr-namespace:Falsechat.ComponentsFalsechat.Components  5      %    Falsechat.View.RegisterPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Falsechat.View     5      8	component"clr-namespace:Falsechat.Components     5        � 	Resources  5
         BoolToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      � $��Stretch=�6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��9* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��2��6   $��SemiBold"�6J   ���#f73e3e$��Center=�6u   ��6$   �� *RegisterInfoLabel+6u   �� 5   
   $��1��6   $	��180��6"   $��Center=�6.   $��	50,0,50,0q�6K   .+�5      �� $��Username��6   $��SemiBold"�6'   � 5      .+�5      �� $!��/Images/Icons/user_icon.png��6   $
��None=�6=   $
��Left=�6L   $��Center=�6g   �� 5      -   5         ��Name$ UsernameTextBox��5   ?     authTextBox#��[ 6   $��1��6X   
������ $��0,0,0,1q�6�   $	��160��6�   $��Right=�6�   $��0,0,0,2q�6�   $��18��6�   $��SemiBold"�6�   ��6h   �� *
Username+66  5      �� 5      -   5        $��InvalidUsername��5      $
��Wrap=�6P   $��DemiBold"�6d   $	��180��6z   $��Center=�6�   ���#f73e3e��6/   �� *InvalidUsername+6�   �� 5      -   5        $��TakenUsername��5      $
��Wrap=�6�   $��DemiBold"�6�   $	��180��6�   $��Center=�6�   ���#f73e3e��6-   �� *TakenUsername+y�6L   �� *TakenUsernameTextVisibility+ �� 	Converter# [  6  �� 5      $��Email��6   $��SemiBold"�6$   � 5        5!      �� 5"      $��20 �6'   �� 5#      $	��160 �6'   .+�5%      �� $"��/Images/Icons/email_icon.png��6   $
��None=�6>   $
��Left=�6M   $��Center=�6h   �� 5&      -   5        $ UserEmailTextBox��5&   ?   #��[ 6   $��1��6Y   
������ $��0,0,0,1q�6�   $	��160��6�   $��Right=�6�   $��	0,0,0,2.5q�6�   $��18��6�   $��SemiBold"�6�   ��6i   �� *	UserEmail+6;  5'      �� 5(      -   5         ��Name$ InvalidEmail��5(      $
��Wrap=�6L   $��DemiBold"�6`   $	��180��6v   $��Center=�6�   ���#f73e3e��6.   �� *InvalidEmail+6�   �� 5)      -   5        $��
TakenEmail��5)      $
��Wrap=�6�   $��DemiBold"�6�   $	��180��6�   $��Center=�6�   ���#f73e3e��6*   �� *
TakenEmail+y�6F   �� *TakenEmailTextVisibility+# [  6�   � 5*      $	��180��6   $
��Left=�6    5+      �� 5,      $��7* �6'   �� 5-      $��3* �6'   .+�5/      �� $��Preferred Language��6   $��SemiBold"�65   �� 50      -   5        $ PreferredLanguageInfo��50      $��1��6;   $��Right=�6K   $��16��6g   $��16��6r    � Cursor$
 Hand��6~   ��51      �� 52       �� ImageSource$! /Images/Icons/info_icon.png��6%   54      55      � 56       57      �� 58      $��20 �6'   �� 59      $	��160 �6'   .+�5;      �� $&�� /Images/Icons/translate_icon.png��6   $
��None=�6B   $
��Left=�6Q   $��Center=�6l   �� 5<      -   5         ��Name$ PreferredLanguageComboBox��5<   C     ComboBoxStyle#���  6   $��1��6f   $��0,0,0,1q�6�   $	��160��6�   $
��Left=�6�   $��22��6  $��SemiBold"�6  ��6v   �� *AvailableLanguages+	 �� Text	 6�   �� *PreferredLanguage+6'  5=      �� 5>      -	   5        $ InvalidLanguage��5>      $
��Wrap=�6R   $��DemiBold"�6f   $	��180��6|   $��Center=�6�   ���#f73e3e��61   �� *InvalidLanguage+6�   �� 5?      -
   5        $ LanguageInfoText��5?      $y�	Collapsed=�62   $	��180��6I   $V��PReceived messages will be automatically translated into your preferred language.��6U   $
��Wrap=�6�   $��SemiBold"�6�   ���#404040$��0,10,0,0q�6�   �� 5@      -   5        $ SecurityKeyInfoText��5@      $y�	Collapsed=�65   $	��180��6L   $:��4The security key allows you to change your password.��6X   $
��Wrap=�6�   $��SemiBold"�6�   ���#404040$��0,10,0,0q�6�   5A      �� 5B   
   $��1��6   $��1��6"   $	��280��62   $��Center=�6>   $��50,0,0,0q�6[   .+�5C      �� $��Password��6   $��SemiBold"�6'   ,   &Falsechat.Components.CustomPasswordBox  5D      -   5        
  Name$
 UserPasswordBox��5D   *   ,   &Falsechat.Components.CustomPasswordBox   	LostFocus$ UserPasswordBox_LostFocus��5F   �      PreviewKeyDown$$ UserPasswordBox_PreviewKeyDown��6�   $��	0,0,0,2.5q�5D   C   $��18��5F   &   $	��180��62   $
��Left=�6>   $��SemiBold"�6Z   $��20,0,0,0q�6p      Password 5E      �� *UserPassword+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���5G      �� 5H      $  /Images/Icons/key_icon.png��6!    j� Stretch$
 None=�6J    j� 
AlignmentX$
 Left=�6Y    j� 
AlignmentY$ Bottom=�6k   5J      �� 5K      -   5        $ InvalidPassword��5K      $
��Wrap=�6R   $��DemiBold"�6f   $	��280��6|   $��Center=�6�   ���#f73e3e��61   �� *InvalidPassword+6�   �� 5L      $��Confirm Password��6   $��SemiBold"�6/     5M      -   5        $
 ConfirmPasswordBox��5M   *   $" ConfirmPasswordBox_LostFocus��5O   [   $' !ConfirmPasswordBox_PreviewKeyDown��6�   $��	0,0,0,2.5q�5M   F   $
��Left=�6Y   $	��180��6t   $��18��5O   &   $��SemiBold"�62   $��20,0,0,0q�6H    5N      �� *ConfirmPassword+$ PropertyChanged=�$ TwoWay=���5P      �� 5Q      $, &/Images/Icons/confirmpassword_icon.png��6!   $
 None=�6V   $
 Left=�6e   $ Bottom=�6w   5S      �� 5T      -   5        $ PasswordNotMatch��5T      $
��Wrap=�6T   $��DemiBold"�6h   $	��280��6~   $��Center=�6�   ���#f73e3e��62   �� *PasswordNotMatch+6�   � 5U      $	��180��6   $
��Left=�6    5V      �� 5W      $��7* �6'   �� 5X      $��3* �6'   .+�5Z      �� $��Security Key��6   $��SemiBold"�6/   �� 5[      -   5        $ SecurityKeyInfo��5[      $��1��65   $��Right=�6E   $��16��6a   $��16��6l   $
 Hand��6x   ��5\      �� 5]      $! /Images/Icons/info_icon.png��6%   5_      5`      � 5a       5b      �� 5c      $��20 �6'   �� 5d      $	��160 �6'   .+�5f      �� $(��"/Images/Icons/securitykey_icon.png��6   $
��None=�6D   $
��Left=�6S   $��Center=�6n   �� 5g      -   5        $ SecurityKeyTextBox��5g   ?   #��[ 6   $��1��6[   
������ $��0,0,0,1q�6�   $	��160��6�   $��Right=�6�   $��	0,0,0,2.5q�6�   $��18��6�   $��SemiBold"�6  ��6k   �� *SecurityKey+6B  5h      �� 5i      -   5        $��InvalidSecurityKey��5i      $
��Wrap=�6V   $��DemiBold"�6j   $	��280��6�   $��Center=�6�   ���#f73e3e��62   �� *InvalidSecurityKey+6�   �� 5j      $#��I agree with Terms of Service��6   $��SemiBold"�6?   $	��200��6U   $
��Left=�6a   $��0,5,0,15q�6|    d� 	IsChecked 6�   �� *	IsChecked+�� 5k      -   5         ��Name$ RegisterButton��5k      $��Register��6-   $
��Bold"�6@   $	��100��6R   $
��Left=�6^   $��80,0,0,0q�6y   $��0q�6�   ���#eeeeee��6�   �� *RegisterCommand+5l      5m      5n      