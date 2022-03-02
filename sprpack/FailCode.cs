namespace sprpack
{
    public enum FailCode
	{
		FailedParsingArguments = 1,
		ImageExporter,
		MapExporter,
		NoImages,
		ImageNameCollision,

		FailedToLoadImage,
		FailedToPackImage,
		FailedToCreateImage,
		FailedToSaveImage,
		FailedToSaveMap
	}
}