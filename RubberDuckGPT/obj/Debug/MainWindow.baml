   M S B A M L   `   `   `  ����H  DRubberDuckGPT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RubberDuckGPTRubberDuckGPT  5   	       RubberDuckGPT.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RubberDuckGPT     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   o� $��0��6   $��0,0,0,10q�6   .@�5      m� -   5        $��Settings��5      6)   5      �� 5   
   $��1��6   $��0,0,0,10q�6$   .��5      �� -   5         ��Name$ txtChatDisplay��5       �� 
IsReadOnly .  �� TextWrapping$
 Wrap=�6@   $
��auto��6T   5      � 5   
   $��2��6   $��5q�6    � ColumnDefinitions 5       �� 5!      $	��90* �6#   �� 5#      $	��10* �6#   .+�5'      �� -   5        $ txtUserInput��5'      $��0��6,   $
 Wrap=�6<    �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�6e   �� 5(      -   5         ��Name$ btnSendMessage��5(      $��1��6-   $
��10,5q�6=   $
��Send��6L   6[   5)      5*      5+      