// Project  : 
// Type     : TRN Tests
// Creation :
// Description:

using System;
using application.trn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//<bucb> User Imports
//<eucb> User Imports

namespace Treinamento.Testes.Bovinos.application.trn
{
	/// <summary>
	/// Testes para transação - TRNAnimal
	/// </summary>
	/// <Author>gmdias</Author>
	/// <Created>2021-01-07T10:18:38-03:00</Created>
	/// <Modified>2021-01-07T10:29:20-03:00</Modified>
    [TestClass]
	public class TRNAnimalTest : BaseTest
    {
		//<bucb> User attributes
		//<eucb> User attributes
		
		//<bucb> User Constants
		//<eucb> User Constants
		
		public TRNAnimalTest() 
			: base()
		{
			//<bucb> TRNAnimalTest()
			//<eucb> TRNAnimalTest()
		}

		[TestMethod()]
		public void EvEditarAnimalTest()
		{
            var trn = new TRNAnimal();
			//<bucb> EvEditarAnimalTest()
            trn.ExecEditarAnimal();
			//<eucb> EvEditarAnimalTest()
            Assert.IsFalse(trn.hasError());
		}

		[TestMethod()]
		public void EvCadastrarAnimalTest()
		{
            var trn = new TRNAnimal();
			//<bucb> EvCadastrarAnimalTest()
            trn.ExecCadastrarAnimal();
			//<eucb> EvCadastrarAnimalTest()
            Assert.IsFalse(trn.hasError());
		}

		[TestMethod()]
		public void EvConsultarAnimalTest()
		{
            var trn = new TRNAnimal();
			//<bucb> EvConsultarAnimalTest()
            trn.ExecConsultarAnimal();
			//<eucb> EvConsultarAnimalTest()
            Assert.IsFalse(trn.hasError());
		}

		[TestMethod()]
		public void EvListarAnimaisTest()
		{
            var trn = new TRNAnimal();
			//<bucb> EvListarAnimaisTest()
            trn.ExecListarAnimais();
			//<eucb> EvListarAnimaisTest()
            Assert.IsFalse(trn.hasError());
		}

		[TestMethod()]
		public void EvRemoverAnimalTest()
		{
            var trn = new TRNAnimal();
			//<bucb> EvRemoverAnimalTest()
            trn.ExecRemoverAnimal();
			//<eucb> EvRemoverAnimalTest()
            Assert.IsFalse(trn.hasError());
		}
		//<bucb> User Defined Tests
		//<eucb> User Defined Tests
    }
}
