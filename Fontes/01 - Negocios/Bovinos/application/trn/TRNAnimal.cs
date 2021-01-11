// Project  : 
// Type     : TRN
// Creation :
// Description:

using System;
using System.Reflection;
using System.Threading;

using com.rerum.rpo;
using com.rerum.sys;
using com.rerum.types;
using com.rerum.trn;
using com.rerum.utils;

using application.types;
using application.bos;
using application.dom;
using application.evt;

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
using POTransaction = com.rerum.trn.RPOTransaction;
// rerum transaction status 
using RTStatus = System.UInt32;
// tipo de retorno para eventos --- indica proximo estado da transacao
using REState = System.Int32;

namespace application.trn
{
	//<bucb>User Aliases 
	//<eucb>User Aliases

	/// <summary>
	/// Transacao negocial TRNAnimal.
	/// </summary>
	/// <Author>gmdias</Author>
	/// <Created>2021-01-07T10:18:38-03:00</Created>
	/// <Modified>2021-01-07T10:29:20-03:00</Modified>
	public class TRNAnimal : RPOTransaction
	//============================================================================================
	{
		//<bucb> TrId : class_id (Tdentificador unico da transacao)
		/// <summary>
		///  TrId : class_id (Tdentificador unico da transacao)
		/// </summary>
		public const int K_TRID_Animal = 1576108922;
		//<eucb>
		
		/// <summary>
		///  TrId : Nome da Transacao -->  RPOTransaction.K_CLID_RPOTransaction + K_TRID_TRNAnimal
		/// </summary>
		public const classid_t K_CLID_Animal = RPOTransaction.K_CLID_RPOTransaction + K_TRID_Animal;

		#region Atributos
		#endregion

		#region Get/Set Atributos
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
		
        public const int K_ST_INICIAL = K_ST_IDLE; // 0
        public const int K_ST_Inicial = 1;
        public const int K_ST_AnimalEditado = 2;
        public const int K_ST_AnimalCadastrado = 3;
        public const int K_ST_AnimalConsultado = 4;
        public const int K_ST_AnimalListaConsultada = 5;
        public const int K_ST_AnimalRemovido = 6;
        public const int K_ST_FIM = 7;

        public const int K_EV_EditarAnimal = 0;
		public const string K_EV_NAME_EditarAnimal = "EvEditarAnimal";
        public const int K_EV_CadastrarAnimal = 1;
		public const string K_EV_NAME_CadastrarAnimal = "EvCadastrarAnimal";
        public const int K_EV_ConsultarAnimal = 2;
		public const string K_EV_NAME_ConsultarAnimal = "EvConsultarAnimal";
        public const int K_EV_ListarAnimais = 3;
		public const string K_EV_NAME_ListarAnimais = "EvListarAnimais";
        public const int K_EV_RemoverAnimal = 4;
		public const string K_EV_NAME_RemoverAnimal = "EvRemoverAnimal";
        public const int K_EV_FIM_TRN_Animal = 5;
        // Tabela de transicao de estados
        protected static String K_XML_TransitionTable =
        "<StateTransitionTable>"
            + "\n<States>"
                + "\n<state name=\"Inicial\"/>"
                + "\n<state name=\"Inicial\"/>"
                + "\n<state name=\"AnimalEditado\"/>"
                + "\n<state name=\"AnimalCadastrado\"/>"
                + "\n<state name=\"AnimalConsultado\"/>"
                + "\n<state name=\"AnimalListaConsultada\"/>"
                + "\n<state name=\"AnimalRemovido\"/>"
                + "\n<state name=\"Fim\"/>"
            + "\n</States>"
            + "\n<Events>"
                + "\n<event name=\"EvEditarAnimal\"		handler=\"evEditarAnimal\" />"
                + "\n<event name=\"EvCadastrarAnimal\"		handler=\"evCadastrarAnimal\" />"
                + "\n<event name=\"EvConsultarAnimal\"		handler=\"evConsultarAnimal\" />"
                + "\n<event name=\"EvListarAnimais\"		handler=\"evListarAnimais\" />"
                + "\n<event name=\"EvRemoverAnimal\"		handler=\"evRemoverAnimal\" />"
                + "\n<event name=\"Finalizar\"   handler=\"finalizar\" />"
            + "\n</Events>"
            + "\n<Transitions>"
                + "\n<error state=\"error\"  meth=\"@erroTransicao\" />"
                + "\n<transition state=\"Inicial\" event=\"EvEditarAnimal\"		nextstate=\"AnimalEditado\" />"
                + "\n<transition state=\"Inicial\" event=\"EvCadastrarAnimal\"		nextstate=\"AnimalCadastrado\" />"
                + "\n<transition state=\"Inicial\" event=\"EvConsultarAnimal\"		nextstate=\"AnimalConsultado\" />"
                + "\n<transition state=\"Inicial\" event=\"EvListarAnimais\"		nextstate=\"AnimalListaConsultada\" />"
                + "\n<transition state=\"Inicial\" event=\"EvRemoverAnimal\"		nextstate=\"AnimalRemovido\" />"
            + "\n</Transitions>"
        + "\n</StateTransitionTable>";

		//<bucb> User Defined Constructors
		//<eucb>

		/// <summary>
		///  Construtor de TRNAnimal. Normaliza classid, trid  e inicializa classe.
		/// </summary>
		public TRNAnimal() 
		{
			registerTRNInformation(true);
		}

		public TRNAnimal(bool regStateMachine) 
		{
			registerTRNInformation(regStateMachine);
		}

		private void registerTRNInformation(bool regStateMachine) 
		{
			m_classid = K_CLID_Animal;
			trid = K_TRID_Animal;
			
			if (regStateMachine) 
			{
				registerStateTransitionMachine(K_XML_TransitionTable);
			}
			//<bucb>User Construtor_TRNAnimal 
			//<eucb>User Construtor_TRNAnimal
		}

		#region isValid/begin/end
		/// <summary>
		/// Valida pré-condições para execução da transação 
		/// </summary>
		/// <returns>
		///true- transação pode ser executada    false- transação inválida, não pode ser executada
		/// </returns>
		public override boolean isValid()
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
		/// Inicio de execução da transação: procedimentos de incializacao
		/// </summary>
		/// <returns>
		/// Código de status da inicialização da transação (getStatus()) <p> Exceção de sistema durante o processamento
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
		/// Fim de execução da transação: procedimentos de encerramento
		/// </summary>
		/// <returns>
		/// Código de status da inicialização da transação (getStatus()) <p> Exceção de sistema durante o processamento
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
		
        /// <summary>
        /// Obtem o evento com base no nome recebido.
        /// </summary>
        /// <typeparam name="T">tipo de retorno do evento.</typeparam>
        /// <param name="pEventName">nome do evento.</param>
        /// <returns>evento recuperado ou nulo caso contrario.</returns>	
        protected virtual T GetEventByName<T>(string pEventName) where T : RTEvent
        {
            T evt = null;
            if (evt == null || !string.IsNullOrWhiteSpace(pEventName))
            {
                switch (pEventName)
                {
                    case K_EV_NAME_EditarAnimal: evt = new EvEditarAnimal(this, K_EV_NAME_EditarAnimal) as T; break;
                    case K_EV_NAME_CadastrarAnimal: evt = new EvCadastraAnimal(this, K_EV_NAME_CadastrarAnimal) as T; break;
                    case K_EV_NAME_ConsultarAnimal: evt = new EvConsultarAnimal(this, K_EV_NAME_ConsultarAnimal) as T; break;
                    case K_EV_NAME_ListarAnimais: evt = new EvListarAnimais(this, K_EV_NAME_ListarAnimais) as T; break;
                    case K_EV_NAME_RemoverAnimal: evt = new EvRemoverAnimal(this, K_EV_NAME_RemoverAnimal) as T; break;
					//<bucb> GetEventByName
					//<eucb> GetEventByName
					default: break;
				}
            }
            return evt;
        }
		
		#endregion

		#region eventos
		
		#endregion

		#region exec's

		/// <summary>
		/// $e.doc
		/// </summary>
		public status_t ExecEditarAnimal()
		{
			var evt = GetEventByName<EvEditarAnimal>(K_EV_NAME_EditarAnimal);
			
			//<bucb>Set ExecEditarAnimal
			//<eucb>Set ExecEditarAnimal
			
			setStatus(exec(evt));
			
			//<bucb>Get ExecEditarAnimal
			//<eucb>Get ExecEditarAnimal
			
			return getStatus();
		}

		/// <summary>
		/// $e.doc
		/// </summary>
		public status_t ExecCadastrarAnimal()
		{
			var evt = GetEventByName<EvCadastraAnimal>(K_EV_NAME_CadastrarAnimal);
			
			//<bucb>Set ExecCadastrarAnimal
			//<eucb>Set ExecCadastrarAnimal
			
			setStatus(exec(evt));
			
			//<bucb>Get ExecCadastrarAnimal
			//<eucb>Get ExecCadastrarAnimal
			
			return getStatus();
		}

		/// <summary>
		/// $e.doc
		/// </summary>
		public status_t ExecConsultarAnimal()
		{
			var evt = GetEventByName<EvConsultarAnimal>(K_EV_NAME_ConsultarAnimal);
			
			//<bucb>Set ExecConsultarAnimal
			//<eucb>Set ExecConsultarAnimal
			
			setStatus(exec(evt));
			
			//<bucb>Get ExecConsultarAnimal
			//<eucb>Get ExecConsultarAnimal
			
			return getStatus();
		}

		/// <summary>
		/// $e.doc
		/// </summary>
		public status_t ExecListarAnimais()
		{
			var evt = GetEventByName<EvListarAnimais>(K_EV_NAME_ListarAnimais);
			
			//<bucb>Set ExecListarAnimais
			//<eucb>Set ExecListarAnimais
			
			setStatus(exec(evt));
			
			//<bucb>Get ExecListarAnimais
			//<eucb>Get ExecListarAnimais
			
			return getStatus();
		}

		/// <summary>
		/// $e.doc
		/// </summary>
		public status_t ExecRemoverAnimal()
		{
			var evt = GetEventByName<EvRemoverAnimal>(K_EV_NAME_RemoverAnimal);
			
			//<bucb>Set ExecRemoverAnimal
			//<eucb>Set ExecRemoverAnimal
			
			setStatus(exec(evt));
			
			//<bucb>Get ExecRemoverAnimal
			//<eucb>Get ExecRemoverAnimal
			
			return getStatus();
		}

		#endregion
		
		//<bucb>User NegociaisPublicos
		//<eucb>User NegociaisPublicos

		//<bucb>User NegociaisProtegidos
		//<eucb>User NegociaisProtegidos
		
		//<bucb>User NegociaisPrivados
		//<eucb>User NegociaisPrivados

	}  // End public class TRNAnimal : TRNRPOTransaction
}   // End namespace application.trn
