// Project  : 
// Type     : BOS
// Creation :
// Description:
#region imports
using System;

using com.rerum.rpo;
using com.rerum.sys;
using com.rerum.types;

using application.types;
using application.dom;

//<bucb>User Imports
//<eucb>User Imports

using String        = System.String;
using boolean       = System.Boolean;  
using Object        = System.Object;
using status_t      = System.UInt32;
using classid_t     = System.UInt32;
using TStatus       = System.UInt32;
using RTStatus      = System.UInt32;
using RJStatus      = System.UInt32;
using RJPOObject    = com.rerum.rpo.RPOObject;
using TCodigoObjeto = com.rerum.types.TObjectId;
using RJTTList      = com.rerum.rpo.RTTList;
#endregion
namespace application.bos
{
	/// <summary>
	///  Objeto negocial Animal
	/// </summary>
	/// <Author>gmdias</Author>
	/// <Created>2021-01-07T09:59:33-03:00</Created>
	/// <Modified>2021-01-07T10:05:07-03:00</Modified>
	//<bucb>User Attributes
	//<eucb>User Attributes
	public class Animal : RPOObject
	{
		/// <summary>
		/// ClassId : identificador unico da classe 
		/// </summary>
		//<bucb>ClassId
		public const int K_CLID_Animal = 0;
		//<eucb>ClassId

		#region Atributos
		/// <summary>
		/// NA
		/// </summary>
		protected TString id_animal = new TString();
		/// <summary>
		/// NA
		/// </summary>
		protected TString nome = new TString();
		/// <summary>
		/// NA
		/// </summary>
		protected TData data_nasc = new TData();
		/// <summary>
		/// NA
		/// </summary>
		protected TString raça = new TString();
		/// <summary>
		/// NA
		/// </summary>
		protected TString fazenda = new TString();
		/// <summary>
		/// NA
		/// </summary>
		protected TString sexo = new TString();
		/// <summary>
		/// NA
		/// </summary>
		protected TInt peso = new TInt();
		#endregion

		#region Get/Set Atributos
		public TString getId_animal()
		{
			//<bucb> getId_animal()
			//<eucb> getId_animal()
			return id_animal;
		}

		public void setId_animal(TString value)
		{
			//<bucb> setId_animal(TString value)
			//<eucb> setId_animal(TString value)
			this.id_animal = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public TString Id_animal
		{
			get { return getId_animal(); }
			set { setId_animal(value); }
		}
		public TString getNome()
		{
			//<bucb> getNome()
			//<eucb> getNome()
			return nome;
		}

		public void setNome(TString value)
		{
			//<bucb> setNome(TString value)
			//<eucb> setNome(TString value)
			this.nome = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public TString Nome
		{
			get { return getNome(); }
			set { setNome(value); }
		}
		public TData getData_nasc()
		{
			//<bucb> getData_nasc()
			//<eucb> getData_nasc()
			return data_nasc;
		}

		public void setData_nasc(TData value)
		{
			//<bucb> setData_nasc(TData value)
			//<eucb> setData_nasc(TData value)
			this.data_nasc = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public TData Data_nasc
		{
			get { return getData_nasc(); }
			set { setData_nasc(value); }
		}
		public TString getRaça()
		{
			//<bucb> getRaça()
			//<eucb> getRaça()
			return raça;
		}

		public void setRaça(TString value)
		{
			//<bucb> setRaça(TString value)
			//<eucb> setRaça(TString value)
			this.raça = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public TString Raça
		{
			get { return getRaça(); }
			set { setRaça(value); }
		}
		public TString getFazenda()
		{
			//<bucb> getFazenda()
			//<eucb> getFazenda()
			return fazenda;
		}

		public void setFazenda(TString value)
		{
			//<bucb> setFazenda(TString value)
			//<eucb> setFazenda(TString value)
			this.fazenda = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public TString Fazenda
		{
			get { return getFazenda(); }
			set { setFazenda(value); }
		}
		public TString getSexo()
		{
			//<bucb> getSexo()
			//<eucb> getSexo()
			return sexo;
		}

		public void setSexo(TString value)
		{
			//<bucb> setSexo(TString value)
			//<eucb> setSexo(TString value)
			this.sexo = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public TString Sexo
		{
			get { return getSexo(); }
			set { setSexo(value); }
		}
		public TInt getPeso()
		{
			//<bucb> getPeso()
			//<eucb> getPeso()
			return peso;
		}

		public void setPeso(TInt value)
		{
			//<bucb> setPeso(TInt value)
			//<eucb> setPeso(TInt value)
			this.peso = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public TInt Peso
		{
			get { return getPeso(); }
			set { setPeso(value); }
		}
		#endregion
		
		#region Associacoes
		#endregion

		#region Get/Set Associacoes
		#endregion
		
		#region Agregacoes
		#endregion

		#region Get/Set Agregacoes
		#endregion

		//<bucb>User Consts
		//<eucb>User Consts

		//<bucb>User Atributos 
		//<eucb>User Atributos
		
		//<bucb> User Defined Constructors
		//<eucb> User Defined Constructors

		/// <summary>
		/// Construtor de Animal(). Normaliza classid e inicializa classe.
		/// </summary>
		public Animal()
		//--------------------------------------------------------------------------------------------
		{
			m_classid = K_CLID_Animal;

			//<bucb>User ConstrutorAnimal
			//<eucb>User ConstrutorAnimal
		}
		
        public override boolean isValid()
        {
            var baseOk = base.isValid();
			var localOk = true;
			//<bucb> isValid()
			//<eucb> isValid()
			return baseOk && localOk;
        }

		//<bucb>User NegociaisPublicos
		//<eucb>User NegociaisPublicos

		//<bucb>User NegociaisProtegidos
		//<eucb>User NegociaisProtegidos
		
		//<bucb>User NegociaisPrivados
		//<eucb>User NegociaisPrivados
		
		#region Rec Agregacoes
		#endregion

	} // End public class Animal : RPOObject

} // End namespace application.bos
