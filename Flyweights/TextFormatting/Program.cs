var ft = new FormattedText("white walls blue walls mirrors and halls.");
ft.Capitalize(0,0);
ft.Capitalize(6,6);
ft.Capitalize(12,12);
ft.Capitalize(17,17);
ft.Capitalize(23,23);
ft.Capitalize(35,35);
WriteLine(ft);

var bft = new BetterFormattedText("white walls blue walls mirrors and halls.");
bft.GetRange(12, 15).Capitalize = true;
WriteLine(bft);