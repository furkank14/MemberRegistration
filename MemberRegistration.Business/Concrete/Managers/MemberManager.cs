using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Aspects.PostSharp.ValidationAspects;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.KpsServiceReference;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Concrete.Managers
{
    public class MemberManager:IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            if (_kpsService.ValidateUser(member)==false)
            {
                throw new Exception("Böyle bir kişi yok.");
            }
            _memberDal.Add(member);
        }
    }
}
