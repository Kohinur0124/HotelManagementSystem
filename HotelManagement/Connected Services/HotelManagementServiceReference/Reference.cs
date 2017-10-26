﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.HotelManagementServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelManagementServiceReference.IHMSService")]
    public interface IHMSService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRooms", ReplyAction="http://tempuri.org/IHMSService/GetRoomsResponse")]
        HMS.Models.Room[] GetRooms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRooms", ReplyAction="http://tempuri.org/IHMSService/GetRoomsResponse")]
        System.Threading.Tasks.Task<HMS.Models.Room[]> GetRoomsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateRoom", ReplyAction="http://tempuri.org/IHMSService/CreateRoomResponse")]
        void CreateRoom(HMS.Models.Room roomObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateRoom", ReplyAction="http://tempuri.org/IHMSService/CreateRoomResponse")]
        System.Threading.Tasks.Task CreateRoomAsync(HMS.Models.Room roomObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateRoomCategory", ReplyAction="http://tempuri.org/IHMSService/CreateRoomCategoryResponse")]
        void CreateRoomCategory(HMS.Models.RoomCategory roomCategoryObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateRoomCategory", ReplyAction="http://tempuri.org/IHMSService/CreateRoomCategoryResponse")]
        System.Threading.Tasks.Task CreateRoomCategoryAsync(HMS.Models.RoomCategory roomCategoryObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetBookingStatus", ReplyAction="http://tempuri.org/IHMSService/GetBookingStatusResponse")]
        HMS.Models.Booking[] GetBookingStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetBookingStatus", ReplyAction="http://tempuri.org/IHMSService/GetBookingStatusResponse")]
        System.Threading.Tasks.Task<HMS.Models.Booking[]> GetBookingStatusAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateBooking", ReplyAction="http://tempuri.org/IHMSService/CreateBookingResponse")]
        void CreateBooking(HMS.Models.Booking bookingObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateBooking", ReplyAction="http://tempuri.org/IHMSService/CreateBookingResponse")]
        System.Threading.Tasks.Task CreateBookingAsync(HMS.Models.Booking bookingObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomerDetails", ReplyAction="http://tempuri.org/IHMSService/GetCustomerDetailsResponse")]
        HMS.Models.CustomerDetails[] GetCustomerDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomerDetails", ReplyAction="http://tempuri.org/IHMSService/GetCustomerDetailsResponse")]
        System.Threading.Tasks.Task<HMS.Models.CustomerDetails[]> GetCustomerDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetHotels", ReplyAction="http://tempuri.org/IHMSService/GetHotelsResponse")]
        HMS.Models.Hotel[] GetHotels();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetHotels", ReplyAction="http://tempuri.org/IHMSService/GetHotelsResponse")]
        System.Threading.Tasks.Task<HMS.Models.Hotel[]> GetHotelsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateHotel", ReplyAction="http://tempuri.org/IHMSService/CreateHotelResponse")]
        void CreateHotel(HMS.Models.Hotel hotelObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateHotel", ReplyAction="http://tempuri.org/IHMSService/CreateHotelResponse")]
        System.Threading.Tasks.Task CreateHotelAsync(HMS.Models.Hotel hotelObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateUser", ReplyAction="http://tempuri.org/IHMSService/CreateUserResponse")]
        void CreateUser(HMS.Models.Customer customerObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateUser", ReplyAction="http://tempuri.org/IHMSService/CreateUserResponse")]
        System.Threading.Tasks.Task CreateUserAsync(HMS.Models.Customer customerObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/DeleteRoomById", ReplyAction="http://tempuri.org/IHMSService/DeleteRoomByIdResponse")]
        void DeleteRoomById(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/DeleteRoomById", ReplyAction="http://tempuri.org/IHMSService/DeleteRoomByIdResponse")]
        System.Threading.Tasks.Task DeleteRoomByIdAsync(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomers", ReplyAction="http://tempuri.org/IHMSService/GetCustomersResponse")]
        HMS.Models.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomers", ReplyAction="http://tempuri.org/IHMSService/GetCustomersResponse")]
        System.Threading.Tasks.Task<HMS.Models.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomsByCategoryId", ReplyAction="http://tempuri.org/IHMSService/GetRoomsByCategoryIdResponse")]
        HMS.Models.Room[] GetRoomsByCategoryId(int roomCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomsByCategoryId", ReplyAction="http://tempuri.org/IHMSService/GetRoomsByCategoryIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.Room[]> GetRoomsByCategoryIdAsync(int roomCategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomCategoryTypes", ReplyAction="http://tempuri.org/IHMSService/GetRoomCategoryTypesResponse")]
        HMS.Models.RoomCategory[] GetRoomCategoryTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomCategoryTypes", ReplyAction="http://tempuri.org/IHMSService/GetRoomCategoryTypesResponse")]
        System.Threading.Tasks.Task<HMS.Models.RoomCategory[]> GetRoomCategoryTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomCapacity", ReplyAction="http://tempuri.org/IHMSService/GetRoomCapacityResponse")]
        HMS.Models.RoomCapacity[] GetRoomCapacity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomCapacity", ReplyAction="http://tempuri.org/IHMSService/GetRoomCapacityResponse")]
        System.Threading.Tasks.Task<HMS.Models.RoomCapacity[]> GetRoomCapacityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomerByCustomerDetailsId", ReplyAction="http://tempuri.org/IHMSService/GetCustomerByCustomerDetailsIdResponse")]
        HMS.Models.CustomerDetails[] GetCustomerByCustomerDetailsId(int customerDetailsId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCustomerByCustomerDetailsId", ReplyAction="http://tempuri.org/IHMSService/GetCustomerByCustomerDetailsIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.CustomerDetails[]> GetCustomerByCustomerDetailsIdAsync(int customerDetailsId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomById", ReplyAction="http://tempuri.org/IHMSService/GetRoomByIdResponse")]
        HMS.Models.Room GetRoomById(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetRoomById", ReplyAction="http://tempuri.org/IHMSService/GetRoomByIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.Room> GetRoomByIdAsync(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCategoryById", ReplyAction="http://tempuri.org/IHMSService/GetCategoryByIdResponse")]
        HMS.Models.RoomCategory GetCategoryById(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCategoryById", ReplyAction="http://tempuri.org/IHMSService/GetCategoryByIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.RoomCategory> GetCategoryByIdAsync(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/RoomDetailInfoById", ReplyAction="http://tempuri.org/IHMSService/RoomDetailInfoByIdResponse")]
        HMS.Models.Room[] RoomDetailInfoById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/RoomDetailInfoById", ReplyAction="http://tempuri.org/IHMSService/RoomDetailInfoByIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.Room[]> RoomDetailInfoByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/LoginUser", ReplyAction="http://tempuri.org/IHMSService/LoginUserResponse")]
        HMS.Models.Customer LoginUser(string Email, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/LoginUser", ReplyAction="http://tempuri.org/IHMSService/LoginUserResponse")]
        System.Threading.Tasks.Task<HMS.Models.Customer> LoginUserAsync(string Email, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetUserByEmail", ReplyAction="http://tempuri.org/IHMSService/GetUserByEmailResponse")]
        HMS.Models.Customer GetUserByEmail(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetUserByEmail", ReplyAction="http://tempuri.org/IHMSService/GetUserByEmailResponse")]
        System.Threading.Tasks.Task<HMS.Models.Customer> GetUserByEmailAsync(string Email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetBookingsByUserId", ReplyAction="http://tempuri.org/IHMSService/GetBookingsByUserIdResponse")]
        HMS.Models.Booking[] GetBookingsByUserId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetBookingsByUserId", ReplyAction="http://tempuri.org/IHMSService/GetBookingsByUserIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.Booking[]> GetBookingsByUserIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/BookingDetailInfoById", ReplyAction="http://tempuri.org/IHMSService/BookingDetailInfoByIdResponse")]
        HMS.Models.Booking[] BookingDetailInfoById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/BookingDetailInfoById", ReplyAction="http://tempuri.org/IHMSService/BookingDetailInfoByIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.Booking[]> BookingDetailInfoByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCapacityById", ReplyAction="http://tempuri.org/IHMSService/GetCapacityByIdResponse")]
        HMS.Models.RoomCapacity GetCapacityById(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/GetCapacityById", ReplyAction="http://tempuri.org/IHMSService/GetCapacityByIdResponse")]
        System.Threading.Tasks.Task<HMS.Models.RoomCapacity> GetCapacityByIdAsync(int roomId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/SetCheckedIn", ReplyAction="http://tempuri.org/IHMSService/SetCheckedInResponse")]
        void SetCheckedIn(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/SetCheckedIn", ReplyAction="http://tempuri.org/IHMSService/SetCheckedInResponse")]
        System.Threading.Tasks.Task SetCheckedInAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/DeleteBookingByCustomerId", ReplyAction="http://tempuri.org/IHMSService/DeleteBookingByCustomerIdResponse")]
        void DeleteBookingByCustomerId(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/DeleteBookingByCustomerId", ReplyAction="http://tempuri.org/IHMSService/DeleteBookingByCustomerIdResponse")]
        System.Threading.Tasks.Task DeleteBookingByCustomerIdAsync(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateCustomerDetails", ReplyAction="http://tempuri.org/IHMSService/CreateCustomerDetailsResponse")]
        void CreateCustomerDetails(HMS.Models.CustomerDetails customerDetailsObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHMSService/CreateCustomerDetails", ReplyAction="http://tempuri.org/IHMSService/CreateCustomerDetailsResponse")]
        System.Threading.Tasks.Task CreateCustomerDetailsAsync(HMS.Models.CustomerDetails customerDetailsObject);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHMSServiceChannel : HotelManagement.HotelManagementServiceReference.IHMSService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HMSServiceClient : System.ServiceModel.ClientBase<HotelManagement.HotelManagementServiceReference.IHMSService>, HotelManagement.HotelManagementServiceReference.IHMSService {
        
        public HMSServiceClient() {
        }
        
        public HMSServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HMSServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HMSServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HMSServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HMS.Models.Room[] GetRooms() {
            return base.Channel.GetRooms();
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Room[]> GetRoomsAsync() {
            return base.Channel.GetRoomsAsync();
        }
        
        public void CreateRoom(HMS.Models.Room roomObject) {
            base.Channel.CreateRoom(roomObject);
        }
        
        public System.Threading.Tasks.Task CreateRoomAsync(HMS.Models.Room roomObject) {
            return base.Channel.CreateRoomAsync(roomObject);
        }
        
        public void CreateRoomCategory(HMS.Models.RoomCategory roomCategoryObject) {
            base.Channel.CreateRoomCategory(roomCategoryObject);
        }
        
        public System.Threading.Tasks.Task CreateRoomCategoryAsync(HMS.Models.RoomCategory roomCategoryObject) {
            return base.Channel.CreateRoomCategoryAsync(roomCategoryObject);
        }
        
        public HMS.Models.Booking[] GetBookingStatus() {
            return base.Channel.GetBookingStatus();
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Booking[]> GetBookingStatusAsync() {
            return base.Channel.GetBookingStatusAsync();
        }
        
        public void CreateBooking(HMS.Models.Booking bookingObject) {
            base.Channel.CreateBooking(bookingObject);
        }
        
        public System.Threading.Tasks.Task CreateBookingAsync(HMS.Models.Booking bookingObject) {
            return base.Channel.CreateBookingAsync(bookingObject);
        }
        
        public HMS.Models.CustomerDetails[] GetCustomerDetails() {
            return base.Channel.GetCustomerDetails();
        }
        
        public System.Threading.Tasks.Task<HMS.Models.CustomerDetails[]> GetCustomerDetailsAsync() {
            return base.Channel.GetCustomerDetailsAsync();
        }
        
        public HMS.Models.Hotel[] GetHotels() {
            return base.Channel.GetHotels();
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Hotel[]> GetHotelsAsync() {
            return base.Channel.GetHotelsAsync();
        }
        
        public void CreateHotel(HMS.Models.Hotel hotelObject) {
            base.Channel.CreateHotel(hotelObject);
        }
        
        public System.Threading.Tasks.Task CreateHotelAsync(HMS.Models.Hotel hotelObject) {
            return base.Channel.CreateHotelAsync(hotelObject);
        }
        
        public void CreateUser(HMS.Models.Customer customerObject) {
            base.Channel.CreateUser(customerObject);
        }
        
        public System.Threading.Tasks.Task CreateUserAsync(HMS.Models.Customer customerObject) {
            return base.Channel.CreateUserAsync(customerObject);
        }
        
        public void DeleteRoomById(int roomId) {
            base.Channel.DeleteRoomById(roomId);
        }
        
        public System.Threading.Tasks.Task DeleteRoomByIdAsync(int roomId) {
            return base.Channel.DeleteRoomByIdAsync(roomId);
        }
        
        public HMS.Models.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public HMS.Models.Room[] GetRoomsByCategoryId(int roomCategoryId) {
            return base.Channel.GetRoomsByCategoryId(roomCategoryId);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Room[]> GetRoomsByCategoryIdAsync(int roomCategoryId) {
            return base.Channel.GetRoomsByCategoryIdAsync(roomCategoryId);
        }
        
        public HMS.Models.RoomCategory[] GetRoomCategoryTypes() {
            return base.Channel.GetRoomCategoryTypes();
        }
        
        public System.Threading.Tasks.Task<HMS.Models.RoomCategory[]> GetRoomCategoryTypesAsync() {
            return base.Channel.GetRoomCategoryTypesAsync();
        }
        
        public HMS.Models.RoomCapacity[] GetRoomCapacity() {
            return base.Channel.GetRoomCapacity();
        }
        
        public System.Threading.Tasks.Task<HMS.Models.RoomCapacity[]> GetRoomCapacityAsync() {
            return base.Channel.GetRoomCapacityAsync();
        }
        
        public HMS.Models.CustomerDetails[] GetCustomerByCustomerDetailsId(int customerDetailsId) {
            return base.Channel.GetCustomerByCustomerDetailsId(customerDetailsId);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.CustomerDetails[]> GetCustomerByCustomerDetailsIdAsync(int customerDetailsId) {
            return base.Channel.GetCustomerByCustomerDetailsIdAsync(customerDetailsId);
        }
        
        public HMS.Models.Room GetRoomById(int roomId) {
            return base.Channel.GetRoomById(roomId);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Room> GetRoomByIdAsync(int roomId) {
            return base.Channel.GetRoomByIdAsync(roomId);
        }
        
        public HMS.Models.RoomCategory GetCategoryById(int roomId) {
            return base.Channel.GetCategoryById(roomId);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.RoomCategory> GetCategoryByIdAsync(int roomId) {
            return base.Channel.GetCategoryByIdAsync(roomId);
        }
        
        public HMS.Models.Room[] RoomDetailInfoById(int id) {
            return base.Channel.RoomDetailInfoById(id);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Room[]> RoomDetailInfoByIdAsync(int id) {
            return base.Channel.RoomDetailInfoByIdAsync(id);
        }
        
        public HMS.Models.Customer LoginUser(string Email, string Password) {
            return base.Channel.LoginUser(Email, Password);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Customer> LoginUserAsync(string Email, string Password) {
            return base.Channel.LoginUserAsync(Email, Password);
        }
        
        public HMS.Models.Customer GetUserByEmail(string Email) {
            return base.Channel.GetUserByEmail(Email);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Customer> GetUserByEmailAsync(string Email) {
            return base.Channel.GetUserByEmailAsync(Email);
        }
        
        public HMS.Models.Booking[] GetBookingsByUserId(int id) {
            return base.Channel.GetBookingsByUserId(id);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Booking[]> GetBookingsByUserIdAsync(int id) {
            return base.Channel.GetBookingsByUserIdAsync(id);
        }
        
        public HMS.Models.Booking[] BookingDetailInfoById(int id) {
            return base.Channel.BookingDetailInfoById(id);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.Booking[]> BookingDetailInfoByIdAsync(int id) {
            return base.Channel.BookingDetailInfoByIdAsync(id);
        }
        
        public HMS.Models.RoomCapacity GetCapacityById(int roomId) {
            return base.Channel.GetCapacityById(roomId);
        }
        
        public System.Threading.Tasks.Task<HMS.Models.RoomCapacity> GetCapacityByIdAsync(int roomId) {
            return base.Channel.GetCapacityByIdAsync(roomId);
        }
        
        public void SetCheckedIn(int userId) {
            base.Channel.SetCheckedIn(userId);
        }
        
        public System.Threading.Tasks.Task SetCheckedInAsync(int userId) {
            return base.Channel.SetCheckedInAsync(userId);
        }
        
        public void DeleteBookingByCustomerId(int customerId) {
            base.Channel.DeleteBookingByCustomerId(customerId);
        }
        
        public System.Threading.Tasks.Task DeleteBookingByCustomerIdAsync(int customerId) {
            return base.Channel.DeleteBookingByCustomerIdAsync(customerId);
        }
        
        public void CreateCustomerDetails(HMS.Models.CustomerDetails customerDetailsObject) {
            base.Channel.CreateCustomerDetails(customerDetailsObject);
        }
        
        public System.Threading.Tasks.Task CreateCustomerDetailsAsync(HMS.Models.CustomerDetails customerDetailsObject) {
            return base.Channel.CreateCustomerDetailsAsync(customerDetailsObject);
        }
    }
}
