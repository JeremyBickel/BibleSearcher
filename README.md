# Bible Searcher
Analytics, Parsing and Organization of God's Special Book for the Purpose of Understanding His Will for Humanity

1. General Parsing
-Tokenization, Bible References, Counts for each unique word and instance of each word

2. Phrasal Concordance
-List of every phrase of any length that occurs more than once and it's location and count

3. Strong's Phrasal Concordance
-Similar to Phrasal Concordance but each phrase is the translation of a Strong's number

4. Verse Relatedness by Phrase Similarity
-Each verse is measured against all other verses for relatedness based on the number of phrases they share

5. Word Categories
-Words (starting with the most frequent) have been sorted into categories as I saw fit, but some were iffy, and I might not have been consistent. You might have different ideas.

6. Synonyms
-Preliminary work from Moby
-Unfinished work from Roget - it's been a challenge for me to correctly parse

7. Pericopes
-Treasury of Scripture Knowledge
-Some others
--These are useful for segmenting the text into events for a larger semantic view of the text

8. Marvel Annotated Bible
-The Hebrew and Greek have both been successfully parsed and written out to data files
--The information in this version includes annotations for more levels of detail than in any other data in this project
---For instance, the MAB NT information ("NTWords.csv") includes 3 levels of annotations in addition to normal Greek morphology.
--- They include Word, Clause and Subclause levels. It might be interesting to do some clustering, along with the morph and word glosses.

9. Blue Letter Bible (BlueLetterBible.org) Greek and Hebrew lexicons and concordances
-They'll send you a free disk of some of their website data. This was from v2.30a

10. Several bits and bobs

By the way, the GUI isn't much, much you can get to another window from the main window that let's you drag and drop words into categories (#5, above).
