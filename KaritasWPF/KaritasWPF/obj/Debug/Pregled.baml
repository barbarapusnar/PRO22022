   M S B A M L   `   `   `  ????E  AKaritasWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:KaritasWPF
KaritasWPF  5   	       KaritasWPF.Pregled   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:KaritasWPF     5   	   -   5          ? Title$  Pregled??5   	   $	??450??6   $	??800??6&    ? 	Resources 5	         OblikaVrstice ?Name ?? CornerRadius ?? 
StartPoint ?? EndPoint ? Offset ? Color ? RowDefinitions	 
? Center
 
? GradientOrigin ?? Opacity 
? RadiusX 
? RadiusY??%)  &	        ?? 5
   
   .R?5      ? $ RowDetailGrid??6   $	??470??5      $
??Auto??5      $??5q?5      .+?5      ?? $
??Left=?6   $	??Top=?5   	   $ 5??5   	   ??5      ?? 5      $	 0,0&?6.   $	 0,1&?6?   .??5      ? $ 0Q?6+   $ 
WhiteSmoke??66   ? 5      $
 0.75Q?6+   $ 	#AAFFFFAA??69   ? 5      $ 1Q?6+   $ 	#AAFFD455??66   5      ._?5      ?  5      ?? 5      $
??Auto ?6,   ?? 5      $??* ?6,   .+?5      ?? $??0??6$   $??10q?5      $??Center=?5       $??18(?5!      $??Black"?5"      $??Opombe??5#      ?? 5$      $??1??6$   $??10q?5%      $
??Left=?5&      $??WrapWithOverflow=?5(      ??5'      ?? *Opombe+5(      5)      5*      ?? 5+      $??0 0 8 0q?6   $ 5??6*   ??5,      
? 5-      $	 0.5,1&?6.   $	
 0,1&?6=   $	 0.3Q?6R   $	 0.8Q?6`   $	 0.8Q?6n   .??5.      ? $ 1Q?6+   $ 	#AA58BD03??66   ? 5/      $ 1Q?6+   $ 
WhiteSmoke??66   50      52      53      54      55      .??56      ?  57   
   ?? 58      $??50 ?6   ?? 59      .+?5;   
   c? $
??Left=?6   $	??Top=?6-   .@?5<      ?? $?? ??6   $??35??6    $??35??6+   ??5=      ?? 5>       ?? ImageSource$ FloppyDisk.ico??6!   5@      ?? 5A      $?? ??6   $??35??6    $??35??6+   ??5B      ?? 5C      $ 
delete.ico??6!   5E      5F      &   System.Windows.Controls.DataGrid  5G   
   -   5          Name$ 	dgPodatki??5G       $??1??6      AutoGenerateColumns .  $
??Left=?5H      $	??Top=?60   $??	10,20,0,0q?5I         RowDetailsTemplate# [  6(      Columns 5J      0  *System.Windows.Controls.DataGridTextColumn  5K      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6%      Header$
 Št.??6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   ?? *ZapŠt+6J     5L      $	 120 6%   $ Datum??6K    61   ?? *Datum+6K     5M      $	 150 6%   $ Namen??6K    61   ?? *Namen+6K     5N      $	 120 6%   $ Znesek??6L    61   ?? *Znesek+6L   5P      5Q      5R      