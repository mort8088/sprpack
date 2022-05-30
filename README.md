# sprpack
Command line sprite sheet packer is a .NET Core fork of SpriteSheetPacker by kellygravelyn.

I removed the windows forms GUI and replaced the Command line argument paser and also the use of System.Draw has been replaced with SixLabors.ImageSharp all in an effort to make this work in linux.

Sprite Sheet Packer is a fully featured tool for combining multiple individual images into a single, efficiently laid out image.

Sprite Sheet Packer supports reading PNG, JPG, BMP, and GIF images and produces a single PNG image with all the images embedded inside of it. The resulting image is transparent anywhere an image is not drawn. The tool also produces an accompanying file that maps the image file names with their rectangles, for use in your program to find the regions of the image you are interested in.

The tool supports options for setting the maximum resulting image size, padding (added to the size of the individual images), as well as options for requiring a power-of-two sized output and a square output.

Here are some sample output files created from 720 individual images found here: http://blogoscoped.com/archive/2006-08-08-n51.html using various combinations of the "Require Power of Two Output" and "Require Square Output" options:

Non-power of two and non-square:

![](https://github.com/nickgravelyn/spritesheetpacker/blob/master/images/Sheet1.png)

Power of two and non-square:

![](https://github.com/nickgravelyn/spritesheetpacker/blob/master/images/Sheet2.png)

Non-power of two and square:

![](https://github.com/nickgravelyn/spritesheetpacker/blob/master/images/Sheet3.png)

Power of two and square:

![](https://github.com/nickgravelyn/spritesheetpacker/blob/master/images/Sheet4.png)

All code was originaly written by Kelly Gravelyn except the code for computing the efficient placement of the rectangles which was taken from the [Nuclex Framework](http://nuclexframework.codeplex.com/).
