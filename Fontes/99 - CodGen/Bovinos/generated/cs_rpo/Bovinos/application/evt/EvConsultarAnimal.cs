// Project  : 
// Type     : Event
// Creation :
// Description:

using System;
using System.Reflection;
using System.Threading;

using com.rerum.rpo;
using com.rerum.sys;
using com.rerum.types;
using com.rerum.utils;

using application.types;
using application.bos;
using application.dom;
using application.trn;
using application.sys;

//<bucb>User Imports
//<eucb>User Imports

using String = System.String;
using boolean = System.Boolean;
using Object = System.Object;
using status_t = System.UInt32;
using classid_t = System.UInt32;
using TStatus = System.UInt32;
using RJStatus = System.UInt32;
using state_t = System.Int32;

// rerum transaction status 
using RTStatus = System.UInt32;
// tipo de retorno para eventos --- indica proximo estado da transacao
using REState = System.Int32;

namespace application.evt
{
	//<bucb>User Aliases 
	//<eucb>User Aliases

	/// <summary>
	/// Evento negocial EvConsultarAnimal.
	/// </summary>
    /// <Author>gmdias</Author>
    /// <Created>2021-01-07T10:05:51-03:00</Created>
    /// <Modified>2021-01-07T10:15:38-03:00</Modified>
	public class EvConsultarAnimal : RTEvent
	//============================================================================================
	{
		#region Atributos
		/// <summary>
		/// NA
		/// </summary>
		private TString id_animal = new TString("");
		/// <summary>
		/// NA
		/// </summary>
		private Animal retornoConsultaAnimal = new Animal();
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
		public Animal getRetornoConsultaAnimal() 
		{
			//<bucb> getRetornoConsultaAnimal()
			//<eucb> getRetornoConsultaAnimal()
			return retornoConsultaAnimal;
		}

		public void setRetornoConsultaAnimal(Animal value) 
		{
			//<bucb> setRetornoConsultaAnimal(Animal value)
			//<eucb> setRetornoConsultaAnimal(Animal value)
			this.retornoConsultaAnimal = value;
		}

		/// <summary>
		/// NA
		/// </summary>
		public Animal RetornoConsultaAnimal 
		{
			get { return getRetornoConsultaAnimal(); }
			set { setRetornoConsultaAnimal(value); }
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
		
		//<bucb>User Defined Constructors
		//<eucb>User Defined Constructors

		/// <summary>
		/// Construtor de EvConsultarAnimal. 
		/// </summary>
		public EvConsultarAnimal(TRNAnimal pTransaction, string pEventName) 
			: base(pTransaction, pEventName)
		{
			//<bucb>User Construtor_EvConsultarAnimal 
			//<eucb>User Construtor_EvConsultarAnimal
		}		

		#region isValid/begin/end/process
		/// <summary>
		/// Valida pré-condições para execução da evento. 
		/// </summary>
		/// <returns>
		/// true - evento pode ser executado, false - evento inválido, não pode ser executada.
		/// </returns>
		public override bool isValid()
		{
			__tracein("isValid()");
			// Chama validacao do pai
			if (base.isValid()) 
			{
				//<bucb>User isValid
				//<eucb>User isValid
			}
			else 
			{
				//<bucb>User else_isValid
				//<eucb>User else_isValid
			}
			__traceout("isValid()");
			return !hasError();
		}

		/// <summary>
		/// Inicio de execução da evento: procedimentos de incializacao
		/// </summary>
		/// <returns>
		/// Código de status da inicialização da evento (getStatus()) <p> Exceção de sistema durante o processamento
		/// </returns>
		public override status_t begin()
		//------------------------------------------------------------------------------
		{
			__tracein("begin()");
			base.begin(); // Chama inicializacao do pai
			__traceout("begin()");

			//<bucb>User begin
			//<eucb>User begin

			return getStatus();
		}

		/// <summary>
		/// Fim de execução da evento: procedimentos de encerramento
		/// </summary>
		/// <returns>
		/// Código de status da inicialização da evento (getStatus()) <p> Exceção de sistema durante o processamento
		/// </returns>
		public override status_t end()
		//------------------------------------------------------------------------------
		{
			__tracein("end()");
			base.end(); // Chama encerramento do pai
			__traceout("end()");
			
			//<bucb>User end 
			//<eucb>User end

			return getStatus();
		}
		
        public override status_t process()
        {
            __tracein("process()");
            //<bucb>User process 
            try
            {
                startTransaction();

            }
            catch (LogicaNegocioException ex)
            {
                setStatus(ex.ErrorCode, ex);
                __trace(ex);
            }
            catch (Exception ex)
            {
                setStatus(RStatus.ERROR);
                __trace(ex);
            }
            finally
            {
                endTransaction();
            }
            //<eucb>User process
			__traceout("process()");
            return getStatus();
        }
		
		#endregion

		//<bucb>User NegociaisPublicos
		//<eucb>User NegociaisPublicos
		
		//<bucb>User NegociaisProtegidos
		//<eucb>User NegociaisProtegidos

		//<bucb>User NegociaisPrivados
		//<eucb>User NegociaisPrivados

	}  // End public class EvConsultarAnimal : EvRTEvent
}   // End namespace application.evt
