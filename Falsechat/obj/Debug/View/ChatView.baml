   M S B A M L   `   `   `  ����D  @Falsechat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Falsechat.ViewFalsechat.View  5          Falsechat.View.ChatView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Falsechat.View     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $	��360 �6   �� 5      $��95 �6   .+�5   
   ��  �� CornerRadius$ 9��6   $��1,1,1,1q�6"   
������ ���#e2e2e2$��5,5,5,5q�6k   ._�5      �� -   5        $
��Auto=�5      $��Disabled=�6>   .��5      �� -   5         ��Name$
 Chat��5      $��10,10,10,10q�6o   ��6-   �� *Chat+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      �   5   "   �� 5   &   $��20 �64   �� 5   &    � ColumnDefinitions 5   "   �� 5   &   �� 5   &   .+�5   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5   &   �� $
��Left=�6H   $��Bottom=�6c   $��15(�6~   $��DemiBold"�6�   
���   ���60   �� *Sender+6�   �� 5   &   $�� ��60   $��Bottom=�69   $��Center=�6T   $��SemiBold"�6q   �� 5   &   $��1��60   $
��Left=�6@   $��Bottom=�6[   $��12(�6�   
���   ���6v   �� *
SentDate+6�   5    #   �� 5!   "   $��1��6,   $��2��69   $
��Wrap=�6j   $��13(�6~   
���   �$��1,0,1,1q�6�   ��6M   �� *SentMessage+6�   5"      5#      5%      5&      5'      �� 5(   
   $��1��6   $	��600��6   $ 9��6*   ���#e2e2e2$��5,0,5,5q�6P   ._�5)      �  5*      �� 5+      $��* �6'   �� 5,      $��75 �6'   .+�5.      �� -   5         ��Name$ 
ChatScroll��5.      $
��Auto=�63   $��Disabled=�6V   .��5/      �� -   5         ��Name$ MessageTextBox��5/         messageTextBox#��[  66    �� 	MaxLength$
 1000��6^   
������ $��0q�6�   	 �� TextWrapping$
	 Wrap=�6�   $��13(�6�   $��DemiBold"�6�   $��5,2,0,2q�6  ��6o   �� *	Message+$ PropertyChanged=�.��6M  
 J� InputBindings
 50      �� 51      
 �� Key$ Return��6P    �� Command 6)   �� *SendMessageCommand+6P   .��52   1   53      54      �� 55      -   5         ��Name$ MessagePlaceHolder��55       K� ZIndex$ -1��68   $��Message��6J   
������ ���#909090$��13(�6�   $��SemiBold"�6�    �� Padding$ 6,2,0,2q�6�   $y�Visible=�6�   �� 56      -   5        $ MessageLengthWarner��56      ���#e2e2e2���#f73e3e$ 3��6c   $��DemiBold"�6t   $y�	Collapsed=�6�   $��Bottom=�6�   $��Right=�6�   $��0,0,20,0q�6�   �� 57      $��1��6   
������ 
�������$��1,0,0,0q�6Z   ��6t   �� *SendMessageCommand+.��58      �� $)��#/Images/Icons/send_message_icon.png��6   59      5:      5;      5<      5=      