   M S B A M L   `   `   `  ����D  @Falsechat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Falsechat.ViewFalsechat.View  5      ;"clr-namespace:Falsechat.ComponentsFalsechat.Components  5      &     Falsechat.View.ResetPasswordView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Falsechat.View     5      8	component"clr-namespace:Falsechat.Components     5        N� 
FontFamily$  
Montserrat)�5	       � 	Resources 5         BoolToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5      �� $	��280��6   .+�5   
   �� $��Email��6   $��SemiBold"�6    $��50,0,0,0q�66   � 5   
   $��50,0,0,0q�6    � ColumnDefinitions 5      �� 5      $��20 �6#   �� 5      $	��160 �6#   .+�5      �� $"��/Images/Icons/email_icon.png��6   $
��None=�6:   $
��Left=�6I   $��Center=�6d   �� 5      -   5         ��Name$ UserEmailTextBox��5   ;     authTextBox#��[ 6   $��1��6U   
������ $��0,0,0,1q�6�   $	��160��6�   $��Right=�6�   $��	0,0,0,2.5q�6�   $��18��6�   $��SemiBold"�6�   ��6e   �� *	UserEmail+68  5      �� 5   
   -   5         ��Name$ InvalidEmail��5      $
��Wrap=�6H   $��DemiBold"�6\   $	��180��6r   $��Center=�6~   ���#f73e3e��6*   �� *InvalidEmail+6�   �� 5   
   -   5        $ 
WrongEmail��5      $
��Wrap=�6�    �� TextAlignment$ Center=�6�   $��DemiBold"�6�   $	��180��6�   ���#f73e3e��6(   �� *
WrongEmail+y�6D   �� *WrongEmailTextVisibility+ �� 	Converter# [  6�   �� 5   
   $��Security Key��6   $��SemiBold"�6'   $��50,0,0,0q�6=   � 5   
   $��50,0,0,0q�6    5      �� 5      $��20 �6#   �� 5      $	��160 �6#   .+�5       �� $(��"/Images/Icons/securitykey_icon.png��6   $
��None=�6@   $
��Left=�6O   $��Center=�6j   �� 5!      -   5        $ SecurityKeyTextBox��5!   ;   #��[ 6   $��1��6W   
������ $��0,0,0,1q�6�   $	��160��6�   $��Right=�6�   $��	0,0,0,2.5q�6�   $��18��6�   $��SemiBold"�6�   ��6g   �� *SecurityKey+6G  5"      �� 5#   
   -   5        $ InvalidSecurityKey��5#      $
��Wrap=�6T   $ Center=�6h   $��DemiBold"�6   $	��180��6�   ���#f73e3e��60   �� *InvalidSecurityKey+6�   �� 5$   
   -   5        $ WrongSecurityKey��5$      $
��Wrap=�6�   $ Center=�6�   $��DemiBold"�6�   $	��180��6�   ���#f73e3e��6.   �� *WrongSecurityKey+y�6P   �� * WrongSecurityKeyTextVisibility+# [  6	  �� 5%   
   $��New Password��6   $��SemiBold"�6'   $��50,0,0,0q�6=   ,   &Falsechat.Components.CustomPasswordBox  5&   
   -   5          Name$ NewPasswordBox��5&   &   ,   &Falsechat.Components.CustomPasswordBox   PreviewKeyDown$# NewPasswordBox_PreviewKeyDown��5(   W   	   	LostFocus$	 NewPasswordBox_LostFocus��6�   $	��180��5&   >   $��	0,0,0,2.5q�6J   $��18��5(   "   $��SemiBold"�6.   $��20,0,0,0q�6D   
   Password
 5'      �� *NewPassword+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���5)      �� 5*       �� ImageSource$  /Images/Icons/key_icon.png��6    j� Stretch$
 None=�6F    j� 
AlignmentX$
 Left=�6U    j� 
AlignmentY$ Bottom=�6g   5,      �� 5-   
   -   5        $ InvalidNewPassword��5-      $
��Wrap=�6T   $��DemiBold"�6h   $	��280��6~   $��Center=�6�   ���#f73e3e��60   �� *InvalidNewPassword+6�   �� 5.   
   $��Confirm New Password��6   $��SemiBold"�6/   $��50,0,0,0q�6E     5/   
   -	   5        $ ConfirmNewPasswordBox��5/   &   $* $ConfirmNewPasswordBox_PreviewKeyDown��51   O   $%	 ConfirmNewPasswordBox_LostFocus��6�   $	��180��5/   E   $��	0,0,0,2.5q�6Q   $��18��51      $��SemiBold"�6&   $��20,0,0,0q�6<   
 50      �� *ConfirmNewPassword+$ PropertyChanged=�$ TwoWay=���52      �� 53      $, &/Images/Icons/confirmpassword_icon.png��6   $
 None=�6R   $
 Left=�6a   $ Bottom=�6s   55      �� 56   
   -
   5        $ NewPasswordNotMatch��56      $
��Wrap=�6V   $��DemiBold"�6j   $	��180��6�   $ Center=�6�   ���#f73e3e��61   �� *NewPasswordNotMatch+6�   �� 57   
   -   5         ��Name$ ResetPassword��57      $��Change Password��6(   $
��Bold"�6B   $��0q�6T   $	��120��6h   ���#eeeeee$��0,10,0,0q�6�   ��6�   �� *ResetPasswordCommand+6�   58      59      