// Project  : 
// Type     : COL
// Creation :
// Description:
using System;
#region imports
using com.rerum.rpo;
using com.rerum.db;
using com.rerum.sys;
using com.rerum.types;
using application.bos;
using application.types;
using application.dom;

//<bucb>User Imports
//<eucb>User Imports

using String          = System.String;
using boolean         = System.Boolean;  
using Object          = System.Object;
using status_t        = System.UInt32;
using classid_t       = System.UInt32;
using TStatus         = System.UInt32;
using RTStatus        = System.UInt32;
using RJStatus        = System.UInt32;
using RJPOObject      = com.rerum.rpo.RPOObject;
using ColRJPOObject   = com.rerum.rpo.RPOColObject;
using TCodigoObjeto   = com.rerum.types.TObjectId;
using ColRPOObject    = com.rerum.rpo.RPOColObject;
#endregion imports

namespace application.col
{ 
	/// <summary>
	/// Objeto negocial Animal
	/// </summary>
	/// <Author>gmdias</Author>
	/// <Created>2021-01-07T09:59:33-03:00</Created>
	/// <Modified>2021-01-07T10:05:07-03:00</Modified>
	public class ColAnimal : ColRPOObject
    {
        /// <summary>
        /// Table Name    -->   "";
        /// </summary>
        internal const String K_TBL_Animal = "";

		/// <summary>
        /// Mapeamento do atributo Id_animal para coluna id_animal
        /// </summary>
        internal const String K_COL_Id_animal = "id_animal";
		/// <summary>
        /// Mapeamento do atributo Nome para coluna nome
        /// </summary>
        internal const String K_COL_Nome = "nome";
		/// <summary>
        /// Mapeamento do atributo Data_nasc para coluna data_nasc
        /// </summary>
        internal const String K_COL_Data_nasc = "data_nasc";
		/// <summary>
        /// Mapeamento do atributo Raça para coluna raça
        /// </summary>
        internal const String K_COL_Raça = "raça";
		/// <summary>
        /// Mapeamento do atributo Fazenda para coluna fazenda
        /// </summary>
        internal const String K_COL_Fazenda = "fazenda";
		/// <summary>
        /// Mapeamento do atributo Sexo para coluna sexo
        /// </summary>
        internal const String K_COL_Sexo = "sexo";
		/// <summary>
        /// Mapeamento do atributo Peso para coluna peso
        /// </summary>
        internal const String K_COL_Peso = "peso";


        /// <summary>
        /// Atributo fisico id_animal, mapeia coluna id_animal
        /// </summary>
        public TString id_animal;  // id_animal
        /// <summary>
        /// Atributo fisico nome, mapeia coluna nome
        /// </summary>
        public TString nome;  // nome
        /// <summary>
        /// Atributo fisico data_nasc, mapeia coluna data_nasc
        /// </summary>
        public TData data_nasc;  // data_nasc
        /// <summary>
        /// Atributo fisico raça, mapeia coluna raça
        /// </summary>
        public TString raça;  // raça
        /// <summary>
        /// Atributo fisico fazenda, mapeia coluna fazenda
        /// </summary>
        public TString fazenda;  // fazenda
        /// <summary>
        /// Atributo fisico sexo, mapeia coluna sexo
        /// </summary>
        public TString sexo;  // sexo
        /// <summary>
        /// Atributo fisico peso, mapeia coluna peso
        /// </summary>
        public TInt peso;  // peso
		//<bucb>User Consts
		//<eucb>User Consts

		//<bucb>User Atributos 
		//<eucb>User Atributos
		
		//<bucb> User Defined Constructors
		//<eucb> User Defined Constructors
		
        /// <summary>
        /// 
        /// </summary>
        public ColAnimal()
        //----------------------------------------------------------------------------------------
        {
            //<bucb> ColAnimal()
			//<eucb> ColAnimal()
        }
   
        /// <summary>
        /// Metodo de identificacao da tabela física que mapeia o objeto (K_TBL_#@BC$className)
        /// </summary>
        /// <returns>
        ///
        /// </returns>
        override public String getTableName()
        //----------------------------------------------------------------------------------------
        { 
            return K_TBL_Animal; 
        }

		// Metodos acessores para as colunas da Tabela
		// Acesso as colunas
        public static RDBColumn colunaId_animal(RDBTable pTbl) 
        { 
            //<bucb> colunaId_animal
            //<eucb> colunaId_animal
            return pTbl.col(K_COL_Id_animal); 
        }
        public static RDBColumn colunaNome(RDBTable pTbl) 
        { 
            //<bucb> colunaNome
            //<eucb> colunaNome
            return pTbl.col(K_COL_Nome); 
        }
        public static RDBColumn colunaData_nasc(RDBTable pTbl) 
        { 
            //<bucb> colunaData_nasc
            //<eucb> colunaData_nasc
            return pTbl.col(K_COL_Data_nasc); 
        }
        public static RDBColumn colunaRaça(RDBTable pTbl) 
        { 
            //<bucb> colunaRaça
            //<eucb> colunaRaça
            return pTbl.col(K_COL_Raça); 
        }
        public static RDBColumn colunaFazenda(RDBTable pTbl) 
        { 
            //<bucb> colunaFazenda
            //<eucb> colunaFazenda
            return pTbl.col(K_COL_Fazenda); 
        }
        public static RDBColumn colunaSexo(RDBTable pTbl) 
        { 
            //<bucb> colunaSexo
            //<eucb> colunaSexo
            return pTbl.col(K_COL_Sexo); 
        }
        public static RDBColumn colunaPeso(RDBTable pTbl) 
        { 
            //<bucb> colunaPeso
            //<eucb> colunaPeso
            return pTbl.col(K_COL_Peso); 
        }

        /// <summary>
        /// Inicializacao da classe de acesso à base de dados. Executa o bind com #@BC$className e
        ///registra as colunas da tabela na classe.
        /// </summary>
        /// <returns>
        ///
        /// </returns>
        override public void setup() 
        {
            // Registro de colunas: DEVE OBEDECER A ORDEM DOS ATRIBUTOS PUBLIC DO COL
			setColumn("id_animal", createColumnRef(K_COL_Id_animal));
			setColumn("nome", createColumnRef(K_COL_Nome));
			setColumn("data_nasc", createColumnRef(K_COL_Data_nasc));
			setColumn("raça", createColumnRef(K_COL_Raça));
			setColumn("fazenda", createColumnRef(K_COL_Fazenda));
			setColumn("sexo", createColumnRef(K_COL_Sexo));
			setColumn("peso", createColumnRef(K_COL_Peso));
            base.setup();   // Deve suceder o registro de colunas do filho
            m_late_bind_clname = "RPOObject.Animal";
            m_late_bind_clid   = Animal.K_CLID_Animal;
            //<bucb> setup
            //<eucb> setup
        }

        override public void convertDbToObject(RPOObject pObj)
        {
			var t_obj = (Animal)pObj;
			base.convertDbToObject(t_obj);
			t_obj.setId_animal(id_animal);
			t_obj.setNome(nome);
			t_obj.setData_nasc(data_nasc);
			t_obj.setRaça(raça);
			t_obj.setFazenda(fazenda);
			t_obj.setSexo(sexo);
			t_obj.setPeso(peso);
			//<bucb> convertDbToObject(RPOObject pObj)
			//<eucb> convertDbToObject(RPOObject pObj)
        }

        override public void convertObjectToDb(RPOObject pObj)
        { 
            try 
            {
                var t_obj = (Animal)pObj;
                base.convertObjectToDb(pObj);
				id_animal = t_obj.getId_animal();
				nome = t_obj.getNome();
				data_nasc = t_obj.getData_nasc();
				raça = t_obj.getRaça();
				fazenda = t_obj.getFazenda();
				sexo = t_obj.getSexo();
				peso = t_obj.getPeso();
            } 
            catch(Exception e_exp) 
            { 
               __trace(e_exp); 
            }
        }

        protected override void prepareWhereClause(RDBSelector t_select, RDBTable t_tab, RPOObject t_criteria) 
        {
            base.prepareWhereClause(t_select, t_tab, t_criteria);
			//<bucb> prepareWhereClause(RDBSelector t_select, RDBTable t_tab, RPOObject t_criteria) 
			//<eucb> prepareWhereClause(RDBSelector t_select, RDBTable t_tab, RPOObject t_criteria) 
        }

        protected override void prepareOrderClause(RDBSelector t_select, RDBTable t_tab, RPOObject t_criteria)  
        {
			//<bucb> prepareOrderClause(RDBSelector t_select, RDBTable t_tab, RPOObject t_criteria)  
			//<eucb> prepareOrderClause(RDBSelector t_select, RDBTable t_tab, RPOObject t_criteria)  
        }
		
		public static string getStaticTableName()
		{
			return K_TBL_Animal;
		}
		
		//<bucb>User NegociaisPublicos
		//<eucb>User NegociaisPublicos

		//<bucb>User NegociaisProtegidos
		//<eucb>User NegociaisProtegidos
		
		//<bucb>User NegociaisPrivados
		//<eucb>User NegociaisPrivados
        
    } //public class ColAnimal : ColRPOObject

}   // End namespace application.col

