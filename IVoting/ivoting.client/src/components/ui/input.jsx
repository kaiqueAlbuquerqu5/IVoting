// Input.jsx
import React from "react";
import { Mail } from "lucide-react";

export function Input({ type = "text", placeholder = "", value, onChange }) {
    return (
        <div className="flex items-center border border-gray-300 rounded-lg px-3 py-2 shadow-sm focus-within:ring-2 focus-within:ring-blue-500 bg-white">
            <Mail className="h-5 w-5 text-gray-400 mr-2" />
            <input
                type={type}
                placeholder={placeholder}
                value={value}
                onChange={onChange}
                className="flex-1 outline-none text-gray-700 placeholder-gray-400"
            />
        </div>
    );
}
