 namespace JCUtility.Common
{
    using System.IO;

    /// <summary>
    /// Extensions for various classes in the <see cref="System.IO"/> namespace.
    /// </summary>
    public static class IOExtensions
    {
        /// <summary>
        /// Reads the input <paramref name="stream"/> into a byte array
        /// </summary>
        /// <param name="stream">The input stream to read</param>
        /// <returns>A byte array with the contents of the input <paramref name="stream"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="stream" /> is null.</exception>
        public static byte[] ReadFully(this Stream stream)
        {
            Ensure.Argument.NotNull(stream, "stream");

            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Checks whether the provided file system object is hidden
        /// </summary>
        /// <param name="fsi">The input file system object</param>
        /// <returns>true if the <paramref name="fsi"/> is hidden; othewise, false</returns>
        public static bool IsHidden(this FileSystemInfo fsi)
        {
            return fsi.Attributes.HasFlag(FileAttributes.Hidden);
        }
    }
}