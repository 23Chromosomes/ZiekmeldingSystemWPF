   M S B A M L   `   `   `  ����J  FP2.3Ziekmelding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:P2._3ZiekmeldingP2._3Ziekmelding  5   	   !    P2._3Ziekmelding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:P2._3Ziekmelding     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgPersonen��5
      $
��Left=�6'   $	��230��6B   $��441,190,-0.4,0q�6O   $	��Top=�6g      AutoGenerateColumns .     CanUserAddRows .  $	��353��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Voornaam��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
voornaam+   ClipboardContentBinding 6T   Z�   5      $ 
Achternaam��6%    69   �� *
achternaam+ 6X   Z�   5      $ Afdeling��6%    67   �� *
afdeling+ 6T   Z� 4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� .+�5   "   �� 	 ��Name$	 btnZiekMelden��6)   -   5        $
��Ziek��5   @   6O   5      5      5        5       5      �� 5      .R�5      �� $	 btnWijzigPersonen��6%   -   5        $��Wijzig��5   @   6Q   5      5        5       5       �� 5!      .R�5"      �� $	 btnVerwijderPersoon��6%   -   5        $��	Verwijder��5"   B   6V   5#      5%      5'      �� 5(   
   $
��Left=�6   $��23��6-   $��
479,75,0,0q�69   
 �� TextWrapping$

 Wrap=�6M   $��Voornaam��6a   $	��Top=�6q   $��73��6�   �� 5)   
   $
��Left=�6   $��23��6-   $��479,104,0,0q�69   $

 Wrap=�6N   $��
Achternaam��6b   $	��Top=�6t   $��73��6�   �� 5*   
   $
��Left=�6   $��23��6-   $��479,131,0,0q�69   $

 Wrap=�6N   $��Afdeling��6b   $	��Top=�6r   $��73��6�   �� 5+   
   -   5         ��Name$ txtVoornaam��5+      $
��Left=�6'   $��23��6B   $��
557,75,0,0q�6N   $

 Wrap=�6b   $�� ��6v   $	��Top=�6   $	��207��6�   �� 5,   
   -   5        $ txtAchternaam��5,      $
��Left=�6)   $��23��6D   $��557,104,0,0q�6P   $

 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��207��6�   �� 5-   
   -   5        $ txtAfdeling��5-      $
��Left=�6'   $��23��6B   $��557,131,0,0q�6N   $

 Wrap=�6c   $�� ��6w   $	��Top=�6�   $	��206��6�   �� 5.   
   -   5        $	 btnToevoegen��5.      $��	Toevoegen��6'   $
��Left=�6;   $��
694,14,0,0q�6V   $	��Top=�6j   $��90��6�   $��29��6�   6�   �� 5/   
   -	   5         ��Name$ 
tbVoornaam��5/      $
��Left=�6(   $��	69,45,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $	��209��6�   $��16��6�   �� 50   
   -
   5        $ tbAchternaam��50      $
��Left=�6*   $��	69,66,0,0q�6E   $
��Wrap=�6X   $	��Top=�6l   $	��209��6�   $��16��6�   (  "System.Windows.Controls.DatePicker  51   
   -   5          Name$ dpDatumZiek��51      $
��Left=�6*   $��	69,87,0,0q�6E   $	��Top=�6X   $	��209��6p   �� 52   
   -   5        $	 btnZiek��52      $��
Meldt ziek��6"   $
��Left=�67   $��128,130,0,0q�6R   $	��Top=�6g   $��75��6   6�     53   
   -   5        $ dgMeldingen��53      $
��Left=�6(   $	��230��6C   $��	0,190,0,0q�6P   $	��Top=�6c   $	��436��6{    .   .   54        55      $ Voornaam��6%    67   �� *personen.voornaam+ 6]   Z�   56      $ 
Achternaam��6%    69   �� *personen.achternaam+ 6a   Z�   57      $ 	Afderling��6%    68   �� *personen.afdeling+ 6^   Z�   58      $ 	DatumZiek��6%    68   �� *	DatumZiek+ �� StringFormat$ d�� 6f   Z�   59      $ 
DatumBeter��6%    69   �� *
DatumBeter+$ d�� 6h   Z�   5:       5;      �� 5<      .R�5=      �� $	 btnWijzigMelding��6%   -   5        $��Wijzig��5=   ?   6P   5>      5@        5A       5B      �� 5C      .R�5D      �� $	 btnVerwijderMelding��6%   -   5        $��	Verwijder��5D   B   6V   5E      5G      5I      5K      5L      