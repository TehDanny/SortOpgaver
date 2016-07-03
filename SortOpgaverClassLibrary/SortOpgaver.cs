using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortOpgaverClassLibrary
{
    public class SortOpgaver
    {
        private List<int> IntList = new List<int>();
        // Hjælpemetode for at få indsat data
        public void FillList(IEnumerable<int> elementer)   // IEnumerable<int>  generel type der kan gennemløbes med foreach
        {
            IntList.AddRange(elementer);
        }
        public List<int> GetIntListCopy()
        {
            return new List<int>(IntList);
        }
        // Hjælpemetode for at se indhold - ved manuel kontrol
        public string GetListElementsAsSting()
        {
            string str = "Listens elementer:" + Environment.NewLine;
            for (int index = 0; index < IntList.Count; ++index)
                str += "IntList[" + index + "] value is " + IntList[index] + Environment.NewLine;
            return str;
        }

        //---------------------------------------------------------------------------------------------
        // Her kommer opgaverne så
        //---------------------------------------------------------------------------------------------
        public void BubbleSort_Primitive()
        {
            // Precondition: 
            //      IntList forudsættes at være usorteret
            // Postcondition:
            //      IntList skal nu være sorteret

            // programmer metoden med brug af simpel bubble sorterings algoritme 

            throw new NotImplementedException();
        }

        public void BubbleSort_Primitive_Optimized()
        {
            // Precondition: 
            //      IntList forudsættes at være usorteret
            // Postcondition:
            //      IntList skal nu være sorteret

            // programmer metoden med brug af bubble sortering idet du nu optimerer, 
            // så du kan afbryde hvis der ikke foretages ombytninger i et gennemløb

            throw new NotImplementedException();
        }

        public void InsertElementInOrderedList(int newValue)
        {
            // Denne metode kan dels ses som selvstændig, dels kan den bruges som del af løsning for en InsertionSort
            // Precondition: 
            //      IntList forudsættes at være sorteret
            // Postcondition:
            //      IntList skal nu være sorteret og indeholde såvel tidligere elementer som det nye

            IntList.Add(newValue);    // opret en plads ekstra sidst i listen, så der er plads totalt set (index for alle)
                                      // Jeg har her valgt blot at indsætte det nye - kan også være et hint til næste opgave
                                      // hvor man til sidst kun mangler at få det sidste med i den sorterede del

            // programmer metoden så elementet indsættes på den rigtige plads
            // Du skal klare løsningen uden "smarte List metoder", men muligheden for tilgang til
            // elementer med index -   IntList[ index]  - kan bruges til både aflæsning og ændring af værdi
            //   tips flyt elementer "bagfra" hvis de er større, så du kan få det nye
            //   ind på den den plads der tilhørte det første element
            // Når du har kodet din egen løsning så undersøg om List har en metode, der løser det nemt
            


            throw new NotImplementedException();
        }

        public void InsertionSort()
        {
            // Precondition: 
            //      IntList forudsættes at være usorteret
            // Postcondition:
            //      IntList skal nu være sorteret

            // programmer metoden med brug af InsertionSort algoritme - du kan her bruge ovenstående InsertElementInOrderedList kode
            // Du kan evt. lave den lidt simpel ved først at lave en kopi af listen, herefter tømme den og 
            // løbe kopien igennem og for hver så bruge InsertElementInOrderedList

            throw new NotImplementedException();
        }

        public void AnotherSortOfYourChoice()
        {
            // Precondition: 
            //      IntList forudsættes at være usorteret
            // Postcondition:
            //      IntList skal nu være sorteret

            // programmer metoden med selvvalgt algoritme

            throw new NotImplementedException();
        }

        public void EasyReverseSort_UsingBuildInSortOnList ()
        {
            // Precondition: 
            //      IntList forudsættes at være usorteret
            // Postcondition:
            //      IntList skal nu være sorteret, men i faldende orden

            // programmer metoden ved "blot" at bruge en eller 2 metoder på List klassen

            throw new NotImplementedException();
        }

    }
}
