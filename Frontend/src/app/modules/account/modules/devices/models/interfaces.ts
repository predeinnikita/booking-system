export interface IDevice {
    id: number;
    name: string;
    year: number;
    description: string;
    bookings: any[]
}

export interface IBooking {
    id: number;
    deviceId: number;
    start: any;
    end: any;
    comment: string;
}

export interface IDevices {
    booked: IDevice[];
    notBooked: IDevice[];
}