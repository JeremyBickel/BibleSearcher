namespace MAB
{
    public class Welcome
    {
        public ClassifyMABOT mabot = new ClassifyMABOT();
        public ClassifyMABNT mabnt = new ClassifyMABNT();
        public VersesOT versesOT = new VersesOT();
        public VersesNT versesNT = new VersesNT();

        public Welcome(ref StreamReader srHebrewParseCodes,
            ref FileStream fsMABOT, ref StreamWriter swMABOT,
            ref StreamReader srMABNT, ref StreamWriter swIntermediateMABNT,
            ref StreamWriter swMABNT, ref StreamWriter swWords, string strIntermediateNTFilename,
            string strProcessedMABOTFilename, string strProcessedMABNTFilename)
        {
            //Reads the original MAB file that was extracted from the onClick tag in the
            //database obtained from UniqueBible and slightly changed from that
            //by adding <verses></verses> root tags, removed <br> and <pr>(?maybe?) tags
            //Creates data structures from it and writes them
            StreamReader srIntermediateMABNT;
            StreamReader srMABOTLoad;
            StreamReader srMABNTLoad;

            mabot.TransformMABOTXML(ref fsMABOT, ref swMABOT);
            
            mabnt.TransformMABNTXML(ref srMABNT, ref swIntermediateMABNT);

            srIntermediateMABNT = new StreamReader(strIntermediateNTFilename);
            mabnt.PostProcessArrows(ref srIntermediateMABNT, ref swMABNT, ref swWords);

            //srMABNTLoad = new StreamReader(strProcessedMABNTFilename);
            //versesNT.Load(ref srMABNTLoad);
            srMABOTLoad = new StreamReader(strProcessedMABOTFilename);
            versesOT.Load(ref srMABOTLoad);
        }

        public Welcome(ref StreamReader srHebrewParseCodes, ref StreamReader srMABOT,
            ref StreamReader srMABNT)
        {
            //Load
            versesOT.ReadHebrewParseCodes(ref srHebrewParseCodes);

            versesOT.Load(ref srMABOT);

            versesNT.Load(ref srMABNT);
        }
    }
}