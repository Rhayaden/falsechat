   M S B A M L   `   `   `  ����D  @Falsechat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Falsechat.ViewFalsechat.View  5      ;"clr-namespace:Falsechat.ComponentsFalsechat.Components  5      "    Falsechat.View.LoginPageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Falsechat.View     5      8	component"clr-namespace:Falsechat.Components     5        N� 
FontFamily$  
Montserrat)�5
      .��5      �� $	��180��6   .+�5   
   �� $��SemiBold"�6/   $
��Wrap=�6E   $	��180��6Y   ���#f73e3e �� TextAlignment$ Center=�6z   ��6   �� *	LoginInfo+6z   �� 5   
   $��Email��6   $��SemiBold"�6    � 5   
    � ColumnDefinitions 5      �� 5      $��20 �6#   �� 5      $	��160 �6#   .+�5      �� $!��/Images/Icons/user_icon.png��6   $
��None=�69   $
��Left=�6H   $��Center=�6c   �� 5         authTextBox#��[  6   $��1��6;   
������ $��0,0,0,1q�6   $	��160��6�   $��Right=�6�   $��	0,0,0,2.5q�6�   $��18��6�   $��SemiBold"�6�   ��6K   �� *	UserEmail+6�   5      �� 5   
   $��Password��6   $��SemiBold"�6#   ,   &Falsechat.Components.CustomPasswordBox  5   
   $��	0,0,0,2.5q�6&   $��18��5   &   $��SemiBold"�62   $��20,0,0,0q�6H      Password 5      �� *UserPassword+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=���5      �� 5       �� ImageSource$  /Images/Icons/key_icon.png��6    j� Stretch$
 None=�6F    j� 
AlignmentX$
 Left=�6U   	 j� 
AlignmentY$	 Bottom=�6g   5      �� 5   
   -   5        
 ��Name$
 LoginButton��5      $��Login��6&   $
��Bold"�66   $��75��6H   $��0q�6S   ���#eeeeee$��0,20,0,0q�6�   ��6|   �� *LoginCommand+6�   5      5       