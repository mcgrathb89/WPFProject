   M S B A M L   `   `   `  ����  WPFApp1    WPFApp1.CreateBooking   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5         PurpleStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius �� Triggers P� Property	 P� Value  BlueGradient4  BlueGradient1  BlueGradient2  KioskStandardDropShadow��%9  &	        �� 5	   
   " ��6$   .�5
      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��$ 2q�60   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   #��z��5   	   $	 4,2q�5   	   $ 5��5   	   #��z��5   	   #��z��5   	   ._�5      � .+�5   "   �� $��content��6k   $��Center=�63   $��Center=�6P   6k   5      5       5      P� 5       �@J�IsMouseOver	 . . �5   "   ��  � ��
 �����6@   �� 5   "    � ��$ 4q�6D   5      P� 5       � {�	 .  . �5   "   ��  � ��
 �����6?   �� 5    "    � ��
 �����6@   �� 5!   "    � ��$ 10q�6D   �� 5"   "    � ��
 �����6?   5#      P� 5$       � ��	 . . �5%   "   �� # �  6?    � ���� 5&   "   # �  6@    � ��5'      5)      5+      �� 5,       �@J�SnapsToDevicePixels . 64   �� 5-       � ��# �  6+   �� 5.       � ��# �  6,   �� 5/       � ��
 �����6+   �� 50       � ��$ Center=�6;   �� 51       � ��$ Center=�69   �� 52       �@��TextAlignment$ Center=�66   �� 53       � ��$ Trebuchet MS)�6+   �� 54       � ��$
 15pt(�6)   �� 55       �@J�Effect# �  6'   �� 56       � {� . 6*   57      58      .��5:      � ��5;   
   �� 5<      
 �� EndPoint$
 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5=      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5>      $ White��6   $ 1Q�6-   � 5?      $ 	#FFB2B2B2��6   $ 0.333Q�61   5@      .+�5B   
   �� $��0q�6   $
��Left=�6&   $	��142��6A   $��
22,115,0,0q�6N   $	��Top=�6b   $	��270��6z   $��22(�6�   ��6�   Z� .@�5C      �� -   5        $��Beauty and the Beast��5C      $��38��6Y   �� 5D      -   5        $��John Wick 2��5D      $��35��6R   �� 5E      -   5        $��Dunkirk��5E      $��29��6N   �� 5F      -   5        $ ��Pirates of the Caribbean 5��5F      $��36��6a   5G      �� 5H   
   $��0q�6   $
��Left=�6&   $	��186��6A   $��299,115,0,0q�6N   $	��Top=�6c   $	��215��6{   $��22(�6�   ��6�   Z� .@�5I      �� -   5        $�� 9.00am��5I      $	��198��6N   �� 5J      -   5        $�� 12.00pm��5J      $	��200��6O   �� 5K      -   5        $�� 3.00pm��5K      $	��191��6N   �� 5L      -   5        $�� 7.00pm��5L      $	��188��6N   �� 5M      -	   5        $��	  10.00pm��5M      $	��205��6P   5N      �� 5O   
   $��Choose your Film:��6   $
��Left=�6,   $��	22,76,0,0q�6G   $	��Top=�6Z   $��22(�6r   $
��Bold"�6�   �� 5P   
   $��Choose your Time:��6   $
��Left=�6,   $��
312,76,0,0q�6G   $	��Top=�6[   $��22(�6s   $
��Bold"�6�   �� 5Q   
   -
   5         ��Name$ NextOptionsButton��5Q      $
��Next��6,   $
��Left=�6;   $��557,492,0,0q�6V   $	��Top=�6k   $	��200��6�   $��40��6�   $��Stencil Std)�6�   $��20(�6�    J� RenderTransformOrigin$ 
0.445,0.55&�6�   #��[  6  
���   �6*  �� 5R   
   -   5        $ BackOptionsButton��5R      $
��Back��6,   $
��Left=�6;   $��
22,492,0,0q�6V   $	��Top=�6j   $	��200��6�   $��40��6�   $��Stencil Std)�6�   $��20(�6�   #��[  6�   
���   �6  �� 5S   
   $��Choose Ticket Type:��6   $
��Left=�6.   $��
22,308,0,0q�6I   $	��Top=�6]   $��22(�6u   $
��Bold"�6�   �� 5T   
   -   5         ��Name$ TextBoxAdultTicket��5T      $��3q�6.   $
��Left=�6B   $��34��6]   $��715,308,0,0q�6i    �� TextWrapping$
 Wrap=�6~   $�� ��6�   $	��Top=�6�   $��42��6�   �� 5U   
   -   5        $ TextBoxChildTicket��5U      $��3q�6.   $
��Left=�6B   $��33��6]   $��715,347,0,0q�6i   $
 Wrap=�6~   $�� ��6�   $	��Top=�6�   $��42��6�   $ 0.509,0.858&�6�   �� 5V   
   -   5        $ TextBoxStudentTicket��5V      $��3q�60   $
��Left=�6D   $��32��6_   $��715,392,0,0q�6k   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��42��6�   $ 0.509,1.064&�6�   �� 5W   
   -   5        $ TextBoxConcessionTicket��5W      $��3q�63   $
��Left=�6G   $��36��6b   $��715,433,0,0q�6n   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $��42��6�   �� 5X   
   $��	Quantity:��6   $
��Left=�6$   $��616,306,0,0q�6?   $	��Top=�6T   $��18(�6l   $��36��6z   �� 5Y   
   $��	Quantity:��6   $
��Left=�6$   $��616,347,0,0q�6?   $	��Top=�6T   $��18(�6l   $��36��6z   $ 0.532,0.728&�6�   �� 5Z   
   $��	Quantity:��6   $
��Left=�6$   $��616,388,0,0q�6?   $	��Top=�6T   $��18(�6l   $��36��6z   �� 5[   
   $��	Quantity:��6   $
��Left=�6$   $��616,433,0,0q�6?   $	��Top=�6T   $��18(�6l   $��36��6z   $ 0.557,1.026&�6�   �� 5\   
   -   5        $�� ��5\      $
��Left=�6   $��	22,10,0,0q�67   $	��Top=�6J   $��75��6b   $��61��6m   #��[  6�   ��5]      �� 5^       �� ImageSource$ Images/Home White.png��6   5`      �� 5a   
   $��Adult��6   $
��Left=�6    $��263,308,0,0q�6;   $	��Top=�6P   $ 
1.07,0.689&�6h   $��22(�6�   �� 5b   
   $��Child��6   $
��Left=�6    $��263,347,0,0q�6;   $	��Top=�6P   $ 
1.07,0.689&�6h   $��22(�6�   $��62��6�   �� 5c   
   $��Student��6   $
��Left=�6"   $��263,391,0,0q�6=   $	��Top=�6R   $ 
1.07,0.689&�6j   $��22(�6�   �� 5d   
   $��
Concession��6   $
��Left=�6%   $��263,436,0,0q�6@   $	��Top=�6U   $ 
1.07,0.689&�6m   $��22(�6�   �� 5e   
   $��Choose a Day:��6   $
��Left=�6(   $��
598,76,0,0q�6C   $	��Top=�6W   $��22(�6o   $
��Bold"�6}   $��39��6�   $	��159��6�   �� 5f   
   $��0q�6   $
��Left=�6&   $	��186��6A   $��575,115,0,0q�6N   $	��Top=�6c   $	��215��6{   $��22(�6�   ��6�   Z� .@�5g      �� -   5        $��Monday��5g      $	��175��6+   67   �� 5h      -   5        $��Tuesday��5h      $	��175��6,   68   �� 5i      -   5        $��	Wednesday��5i      $	��178��6.   6:   �� 5j      -   5        $��Thursday��5j      $	��178��6-   69   �� 5k      -   5        $��Friday��5k      $	��176��6+   $ 0.271,0.351&�6Z   5l      5m      5n      