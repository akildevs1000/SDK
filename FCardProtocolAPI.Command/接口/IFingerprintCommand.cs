using DoNetDrive.Core;
using FCardProtocolAPI.Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCardProtocolAPI.Command
{
    public interface IFingerprintCommand : IFcardCommand
    {
        /// <summary>
        /// 添加人员
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<IFcardCommandResult> AddPerson(IFcardCommandParameter parameter);
        /// <summary>
        /// 在多个设备中添加多个人员
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="commandParameters"></param>
        /// <param name="personModelList"></param>
        /// <returns></returns>
        List<PersonAddRangeErrorInfo> AddPersonPlus(ConnectorAllocator allocator, List<IFcardCommandParameter> commandParameters, List<PersonModel> personModelList);
        /// <summary>
        /// 删除人员
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<IFcardCommandResult> DeletePerson(IFcardCommandParameter parameter);
        /// <summary>
        /// 获取人员详情
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<IFcardCommandResult> GetPersonDetail(IFcardCommandParameter parameter);
        /// <summary>
        /// 获取工作参数
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<IFcardCommandResult> GetWorkParam(IFcardCommandParameter parameter);
        /// <summary>
        /// 设置工作参数
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<IFcardCommandResult> SetWorkParam(IFcardCommandParameter parameter);

        Task<IFcardCommandResult> CommandTest(IFcardCommandParameter parameter);

        Task<IFcardCommandResult> WriteTimeGroup(IFcardCommandParameter parameter);
        Task<IFcardCommandResult> ReadTimeGroup(IFcardCommandParameter parameter);
        Task<IFcardCommandResult> ReadKeepAlive(IFcardCommandParameter parameter);
        Task<IFcardCommandResult> WriteKeepAlive(IFcardCommandParameter parameter);
    }
}
