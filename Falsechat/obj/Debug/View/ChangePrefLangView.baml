   M S B A M L   `   `   `  ����D  @Falsechat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Falsechat.ViewFalsechat.View  5      '    !Falsechat.View.ChangePrefLangView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Falsechat.View     5        � 	Resources  5	         BoolToVisibilityConverter��%   &	        �� 5
   
   6'   5      .��5      � $	��350��6   $��Center=�6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��40 �6   �� 5      $��35 �6   �� 5      $��40 �6   �� 5      $��50 �6   .+�5   
   �� $$��Change your preferred language��6   $��SemiBold"�6:   $��16(�6P   $	��350��6^   � 5   
   $��1��6   $
��Left=�6    � ColumnDefinitions 5      �� 5      $��20 �6#   �� 5      $	��160 �6#   .+�5      �� $&�� /Images/Icons/translate_icon.png��6   $
��None=�6>   $
��Left=�6M   $��Center=�6h   �� 5      -   5         ��Name$ PreferredLanguageComboBox��5   ?     ComboBoxStyle#���  6   $��1��6b   $��0,0,0,1q�6�   $	��160��6�   $
��Left=�6�   $��22��6�   $��SemiBold"�6�    �� Text 6r   �� *NewPreferredLanguage+.@�5      �� $��English��6   �� 5      $��French��6   �� 5      $��Italian��6   �� 5      $��German��6   �� 5       $��
Portuguese��6   �� 5!      $��Russian��6   �� 5"      $��Spanish��6   �� 5#      $��Turkish��6   5$      5%      �� 5&      $��2��6   $D��>The language you choose is the same as your preferred language��6%   $
��Wrap=�6�   $��Center=�6�   $
��Left=�6  $��DemiBold"�6  $	��300��62  ���#f73e3ey�6k   �� *InvalidPrefLangVisibility+ �� 	Converter# [  6>  �� 5'   
   $��3��6   $
��Left=�6   $	��180��69   $��SemiBold"�6E   ���#eeeeee$��Change Preferred Language��6p   ��6�   �� *ChangePrefLangCommand+�� 5(   
   $��4��6   .+�5)      �� -   5         ��Name$ LanguageInfoText��5)      $	��340��62   $V��PReceived messages will be automatically translated into your preferred language.��6>   $
��Wrap=�6�   $��SemiBold"�6�   ���#4040406�   5*      5+      5,      