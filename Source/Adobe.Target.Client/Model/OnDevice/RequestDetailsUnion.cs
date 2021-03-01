namespace Adobe.Target.Client.Model.OnDevice
{
    using System;
    using Adobe.Target.Delivery.Model;

    internal sealed class RequestDetailsUnion
    {
        private readonly RequestDetails requestDetails;
        private readonly MboxRequest mboxRequest;
        private readonly ViewRequest viewRequest;
        private readonly int tag;

        internal RequestDetailsUnion(RequestDetails requestDetails)
        {
            this.requestDetails = requestDetails;
            this.tag = 0;
        }

        internal RequestDetailsUnion(MboxRequest mboxRequest)
        {
            this.mboxRequest = mboxRequest;
            this.tag = 1;
        }

        internal RequestDetailsUnion(ViewRequest viewRequest)
        {
            this.viewRequest = viewRequest;
            this.tag = 2;
        }

        internal RequestDetails GetRequestDetails()
        {
            return this.tag switch
            {
                0 => this.requestDetails,
                1 => new RequestDetails(
                    this.mboxRequest.Address,
                    this.mboxRequest.Parameters,
                    this.mboxRequest.ProfileParameters,
                    this.mboxRequest.Order,
                    this.mboxRequest.Product),
                2 => new RequestDetails(
                    this.viewRequest.Address,
                    this.viewRequest.Parameters,
                    this.viewRequest.ProfileParameters,
                    this.viewRequest.Order,
                    this.viewRequest.Product),
                _ => throw new ApplicationException("Unrecognized tag value: " + this.tag)
            };
        }

        internal T Match<T>(Func<RequestDetails, T> f, Func<MboxRequest, T> g, Func<ViewRequest, T> h)
        {
            return this.tag switch
            {
                0 => f(this.requestDetails),
                1 => g(this.mboxRequest),
                2 => h(this.viewRequest),
                _ => throw new ApplicationException("Unrecognized tag value: " + this.tag)
            };
        }
    }
}
