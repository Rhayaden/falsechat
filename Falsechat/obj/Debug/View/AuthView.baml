   M S B A M L   `   `   `  ����D  @Falsechat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Falsechat.ViewFalsechat.View  5   	   9!clr-namespace:Falsechat.ViewModelFalsechat.ViewModel  5   	       Falsechat.View.AuthView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -viewclr-namespace:Falsechat.View     5   	   7	viewModel!clr-namespace:Falsechat.ViewModel     5   	   -   5        ���#eeeeee$��
Montserrat)�5
   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $	��500��5   	   $	��800��6    � 
ResizeMode$ NoResize=�5   	    � DataContext 5      '   !Falsechat.ViewModel.AuthViewModel  5   
    � 	Resources 5       �� DataType(   "Falsechat.ViewModel.LoginViewModel"   Falsechat.View.LoginPageView+   %Falsechat.ViewModel.RegisterViewModel%   Falsechat.View.RegisterPageView0   *Falsechat.ViewModel.ResetPasswordViewModel&    Falsechat.View.ResetPasswordView   BoolToVisibilityConverter��%�   (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)&	  �     �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   6'   5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5    
      GlassFrameThickness$ 0q�6      CornerRadius$ 3��6/   	   CaptionHeight$	 0Q�6@   .��5"      � 
 � RowDefinitions
 5#   
   �� 5$      $	��.5* �6   �� 5%      $��8* �6   �� 5&      $
��1.5* �6   .+�5(   
   �  � ColumnDefinitions 5)      �� 5*      �� 5+      .+�5-      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�5.      �� $	��Top=�6   $��25��60   $��25��6<   $&�� /Images/Icons/falsechat_icon.png��6G   $��	2.5,0,0,0q�6q   �� 5/      $��	Falsechat��6   $��SemiBold"�6,   50      �� 51      $��1��6   $ 
Horizontal=�6)   $��Right=�6B   .+�52      �� -   5         ��Name$ MinimizeButton��52   >     menuButtons#��[ 6   $
��🗕��6V   
������ $��0q�6}   $��25��6�   $��25��6�   6�   �� 53      -   5        $ CloseButton��53   ?     closeButtons#��[ 6   $	��✖��6T   
������ $��0q�6z   $��25��6�   $��25��6�   6�   54      55      � 56   
   $��1��6   
 57      �� 58      $��3* �6    �� 59      $��7* �6    .+�5;      �� $��Center=�6   .+�5<      �� $	��100��6   $	��100��6%   $ ��/Images/falsechat_logo.png��61   �� 5=      $"��for Effortless Conversations��6   $��SemiBold"�6@   
�������6V   5>      �� 5?      $��1��6   $��Center=�6&   $
��Auto��6C   .+�5@       �   � NavigationUIVisibility$ Hidden=�6^   ��6   �� *FrameContent+ �� UpdateSourceTrigger$ PropertyChanged=�6^   5A      5B      �� 5C   
   $��2��6   $ Vertical=�6"   $��Center=�69   $��Center=�6V   .+�5D      �� -   5        $ ForgotPasswordButton��5D   9     
navButtons#��[ 6   $��Forgot Password ?��6W   $��SemiBold"�6s    � Cursor$
 Hand��6�   $��16��6�   $	��102��6�   y�6�   �� * ForgotPasswordButtonVisibility+ �� 	Converter# [  ��6  �� *ResetPasswordCommand+�� 5E      $!��Don't you have an account ?��6   $��SemiBold"�6:   $��Center=�6�   $	��Top=�6�   y�6P   �� *NoAccountLabelVisibility+# [  6�   �� 5F      #��[ 6   $
 Hand��69   $��SemiBold"�6G   $��Create an Account��6�   $��16��6�   $	��102��6�   y�6]   �� *CreateAccountButtonVisibility+# [  ��6�   �� *MoveRegisterPageCommand+�� 5G      -   5        $ BackToLoginButton��5G   9   #��[ 6   $
 Hand��6T   $��SemiBold"�6b   $��Login��6�   $��16��6�   $
��Auto��6�   y�6x   �� *BackToLoginButtonVisibility+# [  ��6  �� *MoveLoginPageCommand+5H      5I      5J      